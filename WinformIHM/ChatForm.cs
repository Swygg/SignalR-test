using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformIHM
{
    public partial class ChatForm : Form
    {
        private HubConnection _connection;
        private Claim _claim;

        public ChatForm()
        {
            InitializeComponent();
            RemoveAccess();
        }

        private async void btn_Connexion_Click(object sender, EventArgs e)
        {
            _connection = new HubConnectionBuilder()
                 .WithUrl("https://localhost:44339/ChatHub")
                 .WithAutomaticReconnect()
                 .Build();



            _connection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                var newMessage = $"{user}: {message}";
                tb_Chat.Text += newMessage + Environment.NewLine;
            });

            _connection.On<string>("NewConnection", (message) =>
            {
                tb_Chat.Text += message + Environment.NewLine;
            });


            _connection.On<string, string>("GetClaim", (claimName, claimValue) =>
            {
                _claim = new Claim(claimName, claimValue);
            });

            _connection.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await _connection.StartAsync();
            };

            try
            {
                await _connection.StartAsync();
                await _connection.InvokeAsync("GetClaim", tb_Pseudo.Text, tb_Password.Text);
                GiveAccess();
                this.AcceptButton = btn_Send;
                tb_Message.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            RemoveAccess();
        }

        private async void btn_Send_Click(object sender, EventArgs e)
        {
            await Send(tb_Pseudo.Text, tb_Message.Text);
            tb_Message.Text = "";
            tb_Message.Focus();
        }

        private async Task Send(string sender, string message)
        {
            try
            {
                await _connection.InvokeAsync("SendMessage", sender, message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveAccess()
        {
            tb_Pseudo.Enabled = true;
            tb_Password.Enabled = true;
            btn_Connexion.Enabled = true;

            tb_Message.Enabled = false;
            btn_Send.Enabled = false;
            btn_Disconnect.Enabled = false;
        }

        private void GiveAccess()
        {
            tb_Pseudo.Enabled = false;
            tb_Password.Enabled = false;
            btn_Connexion.Enabled = false;

            tb_Message.Enabled = true;
            btn_Send.Enabled = true;
            btn_Disconnect.Enabled = true;
        }
    }
}
