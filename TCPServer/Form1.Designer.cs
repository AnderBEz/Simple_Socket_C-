namespace TCPServer
{
    partial class Form1
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
            listUsers = new ListBox();
            txtChat = new TextBox();
            lbIP = new Label();
            lblPort = new Label();
            txtIP = new TextBox();
            txtPort = new TextBox();
            btnStart = new Button();
            btnSend = new Button();
            txtMsg = new TextBox();
            SuspendLayout();
            // 
            // listUsers
            // 
            listUsers.FormattingEnabled = true;
            listUsers.Location = new Point(37, 70);
            listUsers.Name = "listUsers";
            listUsers.Size = new Size(186, 384);
            listUsers.TabIndex = 1;
            // 
            // txtChat
            // 
            txtChat.BackColor = Color.PeachPuff;
            txtChat.Location = new Point(257, 70);
            txtChat.Multiline = true;
            txtChat.Name = "txtChat";
            txtChat.ReadOnly = true;
            txtChat.ScrollBars = ScrollBars.Both;
            txtChat.Size = new Size(542, 376);
            txtChat.TabIndex = 13;
            // 
            // lbIP
            // 
            lbIP.AutoSize = true;
            lbIP.Location = new Point(34, 37);
            lbIP.Name = "lbIP";
            lbIP.Size = new Size(24, 20);
            lbIP.TabIndex = 17;
            lbIP.Text = "IP:";
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(342, 41);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(55, 20);
            lblPort.TabIndex = 16;
            lblPort.Text = "Puerto:";
            // 
            // txtIP
            // 
            txtIP.Location = new Point(64, 34);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(253, 27);
            txtIP.TabIndex = 15;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(403, 37);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(167, 27);
            txtPort.TabIndex = 14;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.PaleGreen;
            btnStart.Location = new Point(649, 37);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 18;
            btnStart.Text = "Iniciar";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.PeachPuff;
            btnSend.Location = new Point(257, 452);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 19;
            btnSend.Text = "Enviar";
            btnSend.UseVisualStyleBackColor = false;
            // 
            // txtMsg
            // 
            txtMsg.Location = new Point(357, 452);
            txtMsg.Name = "txtMsg";
            txtMsg.Size = new Size(418, 27);
            txtMsg.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 505);
            Controls.Add(txtMsg);
            Controls.Add(btnSend);
            Controls.Add(btnStart);
            Controls.Add(lbIP);
            Controls.Add(lblPort);
            Controls.Add(txtIP);
            Controls.Add(txtPort);
            Controls.Add(txtChat);
            Controls.Add(listUsers);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChatTCP Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listUsers;
        private TextBox txtChat;
        private Label lbIP;
        private Label lblPort;
        private TextBox txtIP;
        private TextBox txtPort;
        private Button btnStart;
        private Button btnSend;
        private TextBox txtMsg;
    }
}
