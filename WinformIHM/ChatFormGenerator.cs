using System;
using System.Windows.Forms;

namespace WinformIHM
{
    public partial class ChatFormGenerator : Form
    {

        public ChatFormGenerator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateCharForm(null);
        }

       

        private void GenerateCharForm(string userName)
        {
            ChatForm form;
            if (string.IsNullOrEmpty(userName))
                form = new ChatForm();
            else
                form = new ChatForm(userName, "123");
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerateCharForm("Alice");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GenerateCharForm("Bob");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GenerateCharForm("Crystal");
        }
    }
}
