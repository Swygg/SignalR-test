
namespace WinformIHM
{
    partial class ChatForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Connexion = new System.Windows.Forms.Button();
            this.tb_Pseudo = new System.Windows.Forms.TextBox();
            this.tb_Message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.tb_Chat = new System.Windows.Forms.TextBox();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Connexion
            // 
            this.btn_Connexion.Location = new System.Drawing.Point(826, 88);
            this.btn_Connexion.Name = "btn_Connexion";
            this.btn_Connexion.Size = new System.Drawing.Size(75, 23);
            this.btn_Connexion.TabIndex = 0;
            this.btn_Connexion.Text = "Connexion";
            this.btn_Connexion.UseVisualStyleBackColor = true;
            this.btn_Connexion.Click += new System.EventHandler(this.btn_Connexion_Click);
            // 
            // tb_Pseudo
            // 
            this.tb_Pseudo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Pseudo.Location = new System.Drawing.Point(460, 30);
            this.tb_Pseudo.Name = "tb_Pseudo";
            this.tb_Pseudo.Size = new System.Drawing.Size(441, 23);
            this.tb_Pseudo.TabIndex = 1;
            this.tb_Pseudo.Text = "Bob";
            // 
            // tb_Message
            // 
            this.tb_Message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Message.Location = new System.Drawing.Point(444, 136);
            this.tb_Message.Multiline = true;
            this.tb_Message.Name = "tb_Message";
            this.tb_Message.Size = new System.Drawing.Size(457, 131);
            this.tb_Message.TabIndex = 2;
            this.tb_Message.Text = "Bonjour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pseudo : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message :";
            // 
            // btn_Send
            // 
            this.btn_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Send.Location = new System.Drawing.Point(822, 273);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 3;
            this.btn_Send.Text = "Envoyer";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // tb_Chat
            // 
            this.tb_Chat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Chat.Location = new System.Drawing.Point(12, 30);
            this.tb_Chat.Multiline = true;
            this.tb_Chat.Name = "tb_Chat";
            this.tb_Chat.ReadOnly = true;
            this.tb_Chat.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_Chat.Size = new System.Drawing.Size(349, 300);
            this.tb_Chat.TabIndex = 4;
            this.tb_Chat.TabStop = false;
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Disconnect.Location = new System.Drawing.Point(789, 307);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(108, 23);
            this.btn_Disconnect.TabIndex = 4;
            this.btn_Disconnect.Text = "Déconnexion";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chat :";
            // 
            // tb_Password
            // 
            this.tb_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Password.Location = new System.Drawing.Point(460, 59);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(441, 23);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.Text = "123";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mot de passe :";
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 342);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Chat);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Message);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Pseudo);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.btn_Connexion);
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Connexion;
        private System.Windows.Forms.TextBox tb_Pseudo;
        private System.Windows.Forms.TextBox tb_Message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox tb_Chat;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label4;
    }
}

