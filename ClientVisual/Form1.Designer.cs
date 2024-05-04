namespace ClientVisual
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
            txtMsg = new TextBox();
            btnSend = new Button();
            txtPort = new TextBox();
            txtIP = new TextBox();
            txtUserName = new TextBox();
            lblPort = new Label();
            lblUser = new Label();
            lbIP = new Label();
            btnConnect = new Button();
            txtChat = new TextBox();
            SuspendLayout();
            // 
            // txtMsg
            // 
            txtMsg.Location = new Point(207, 401);
            txtMsg.Name = "txtMsg";
            txtMsg.Size = new Size(557, 27);
            txtMsg.TabIndex = 2;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.PeachPuff;
            btnSend.Location = new Point(76, 401);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 3;
            btnSend.Text = "Enviar";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(521, 18);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(125, 27);
            txtPort.TabIndex = 4;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(266, 15);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(188, 27);
            txtIP.TabIndex = 5;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(76, 12);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(154, 27);
            txtUserName.TabIndex = 6;
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(460, 19);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(55, 20);
            lblPort.TabIndex = 7;
            lblPort.Text = "Puerto:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(29, 15);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(41, 20);
            lblUser.TabIndex = 8;
            lblUser.Text = "User:";
            // 
            // lbIP
            // 
            lbIP.AutoSize = true;
            lbIP.Location = new Point(236, 18);
            lbIP.Name = "lbIP";
            lbIP.Size = new Size(24, 20);
            lbIP.TabIndex = 9;
            lbIP.Text = "IP:";
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.PaleGreen;
            btnConnect.Location = new Point(670, 16);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(94, 29);
            btnConnect.TabIndex = 10;
            btnConnect.Text = "Conectar";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtChat
            // 
            txtChat.BackColor = Color.PeachPuff;
            txtChat.Location = new Point(76, 66);
            txtChat.Multiline = true;
            txtChat.Name = "txtChat";
            txtChat.ReadOnly = true;
            txtChat.ScrollBars = ScrollBars.Both;
            txtChat.Size = new Size(688, 312);
            txtChat.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtChat);
            Controls.Add(btnConnect);
            Controls.Add(lbIP);
            Controls.Add(lblUser);
            Controls.Add(lblPort);
            Controls.Add(txtUserName);
            Controls.Add(txtIP);
            Controls.Add(txtPort);
            Controls.Add(btnSend);
            Controls.Add(txtMsg);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChatTCP/Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMsg;
        private Button btnSend;
        private TextBox txtPort;
        private TextBox txtIP;
        private TextBox txtUserName;
        private Label lblPort;
        private Label lblUser;
        private Label lbIP;
        private Button btnConnect;
        private TextBox txtChat;
    }
}
