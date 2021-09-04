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
        private string _jwt;

        public ChatForm()
        {
            InitializeComponent();
            RemoveAccess();
        }

        public ChatForm(string userName, string userPassword) : this()
        {
            tb_Pseudo.Text = userName;
            tb_Password.Text = userPassword;
        }

        private async void btn_Connexion_Click(object sender, EventArgs e)
        {
            _connection = new HubConnectionBuilder()
                 .WithUrl("https://localhost:44339/ChatHub")
                 .WithAutomaticReconnect()
                 .Build();



            _connection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                var newMessage = $"{GetDate()} - {user} : {message}";
                tb_Chat.Text += newMessage + Environment.NewLine;
            });

            _connection.On<string>("NewConnection", (message) =>
            {
                //tb_Chat.Text += message + Environment.NewLine;
            });
            _connection.On<string>("NewRealConnection", (message) =>
            {
                tb_Chat.Text += $"{GetDate()} - {message} {Environment.NewLine}";
            });

            _connection.On<string>("GetJwt", (jwt) =>
            {
                _jwt = jwt;
            });


            _connection.On<string>("Notification", (notification) =>
            {
                tb_Chat.Text += notification + Environment.NewLine;
            });

            _connection.On<string, string>("ReceivePrivateMessage", (user, message) =>
            {
                var newMessage = $"{GetDate()} - Message privé de {user} : {message}";
                tb_Chat.Text += newMessage + Environment.NewLine;
            });

            _connection.On<string, string, string>("ReceiveGroupMessage", (group, user, message) =>
            {
                var newMessage = $"{GetDate()} - Message de '{user}' du group '{group}' : {message}";
                tb_Chat.Text += newMessage + Environment.NewLine;
            });

            _connection.On<string>("GetId", (id) =>
            {
                tb_myId.Text = id;
            });

            _connection.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await _connection.StartAsync();
            };

            try
            {
                await _connection.StartAsync();
                await _connection.InvokeAsync("GetJwt", tb_Pseudo.Text, tb_Password.Text);
                await _connection.InvokeAsync("GetId", this._jwt);
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
            if (tb_TargetId.Text.Length > 0)
                await _connection.InvokeAsync("SendMessage", this._jwt, tb_Message.Text);
            else if (tb_GroupeName.Text.Length > 0)
                await _connection.InvokeAsync("SendGroupMessage", this._jwt, tb_GroupeName.Text, tb_Message.Text);
            else
                await _connection.InvokeAsync("SendMessage", this._jwt, tb_Message.Text);

            tb_Message.ResetText();
            tb_Message.Focus();
        }

        private void RemoveAccess()
        {
            tb_Pseudo.Enabled = true;
            tb_Password.Enabled = true;
            btn_Connexion.Enabled = true;

            tb_Message.Enabled = false;
            btn_Send.Enabled = false;
            btn_Disconnect.Enabled = false;
            tb_myId.Enabled = false;
        }

        private void GiveAccess()
        {
            tb_Pseudo.Enabled = false;
            tb_Password.Enabled = false;
            btn_Connexion.Enabled = false;

            tb_Message.Enabled = true;
            btn_Send.Enabled = true;
            btn_Disconnect.Enabled = true;
            tb_myId.Enabled = true;
        }

        private string GetDate()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
