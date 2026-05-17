namespace WinFormsClient
{
    partial class FormClient
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtLocalPort = new TextBox();
            txtIp = new TextBox();
            txtRemotePort = new TextBox();
            txtMessage = new TextBox();
            btnSend = new Button();
            btnCreateUser = new Button();
            btnStart = new Button();
            rtbChat = new RichTextBox();
            colorDialog1 = new ColorDialog();
            btnGetColorMessage = new Button();
            cmbUsers = new ComboBox();
            txtUsername = new TextBox();
            label5 = new Label();
            cbmChats = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 2, 85);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(17, 470);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Local Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 2, 85);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(17, 503);
            label2.Name = "label2";
            label2.Size = new Size(23, 20);
            label2.TabIndex = 1;
            label2.Text = "Ip";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 2, 85);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(17, 536);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 2;
            label3.Text = "Remote Port";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 2, 85);
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(12, 367);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Message";
            // 
            // txtLocalPort
            // 
            txtLocalPort.BackColor = Color.FromArgb(0, 2, 85);
            txtLocalPort.ForeColor = Color.Yellow;
            txtLocalPort.Location = new Point(121, 463);
            txtLocalPort.Name = "txtLocalPort";
            txtLocalPort.PlaceholderText = "Your port...";
            txtLocalPort.Size = new Size(931, 27);
            txtLocalPort.TabIndex = 4;
            // 
            // txtIp
            // 
            txtIp.BackColor = Color.FromArgb(0, 2, 85);
            txtIp.ForeColor = Color.Yellow;
            txtIp.Location = new Point(121, 496);
            txtIp.Name = "txtIp";
            txtIp.PlaceholderText = "Your ip...";
            txtIp.Size = new Size(931, 27);
            txtIp.TabIndex = 5;
            // 
            // txtRemotePort
            // 
            txtRemotePort.BackColor = Color.FromArgb(0, 2, 85);
            txtRemotePort.ForeColor = Color.Yellow;
            txtRemotePort.Location = new Point(121, 529);
            txtRemotePort.Name = "txtRemotePort";
            txtRemotePort.PlaceholderText = "Remote user port...";
            txtRemotePort.Size = new Size(931, 27);
            txtRemotePort.TabIndex = 6;
            // 
            // txtMessage
            // 
            txtMessage.BackColor = Color.FromArgb(0, 2, 85);
            txtMessage.ForeColor = Color.Yellow;
            txtMessage.Location = new Point(88, 360);
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = "Type something...";
            txtMessage.Size = new Size(964, 27);
            txtMessage.TabIndex = 7;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(0, 2, 85);
            btnSend.ForeColor = Color.Yellow;
            btnSend.Location = new Point(12, 393);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(1040, 29);
            btnSend.TabIndex = 11;
            btnSend.Text = "Send message";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnCreateUser
            // 
            btnCreateUser.BackColor = Color.FromArgb(0, 2, 85);
            btnCreateUser.ForeColor = Color.Yellow;
            btnCreateUser.Location = new Point(12, 595);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(1040, 29);
            btnCreateUser.TabIndex = 12;
            btnCreateUser.Text = "Create and add user";
            btnCreateUser.UseVisualStyleBackColor = false;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(0, 2, 85);
            btnStart.ForeColor = Color.Yellow;
            btnStart.Location = new Point(12, 630);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(1040, 29);
            btnStart.TabIndex = 13;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // rtbChat
            // 
            rtbChat.BackColor = Color.FromArgb(0, 2, 85);
            rtbChat.ForeColor = Color.Yellow;
            rtbChat.Location = new Point(12, 12);
            rtbChat.Name = "rtbChat";
            rtbChat.Size = new Size(1040, 342);
            rtbChat.TabIndex = 14;
            rtbChat.Text = "";
            // 
            // btnGetColorMessage
            // 
            btnGetColorMessage.BackColor = Color.FromArgb(0, 2, 85);
            btnGetColorMessage.Location = new Point(12, 428);
            btnGetColorMessage.Name = "btnGetColorMessage";
            btnGetColorMessage.Size = new Size(1040, 29);
            btnGetColorMessage.TabIndex = 15;
            btnGetColorMessage.Text = "Your color messages";
            btnGetColorMessage.UseVisualStyleBackColor = false;
            btnGetColorMessage.Click += btnGetColorMessage_Click;
            // 
            // cmbUsers
            // 
            cmbUsers.BackColor = Color.FromArgb(0, 2, 85);
            cmbUsers.ForeColor = Color.Yellow;
            cmbUsers.FormattingEnabled = true;
            cmbUsers.Location = new Point(77, 665);
            cmbUsers.Name = "cmbUsers";
            cmbUsers.Size = new Size(980, 28);
            cmbUsers.TabIndex = 16;
            cmbUsers.SelectedIndexChanged += cmbUsers_SelectedIndexChanged;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(0, 2, 85);
            txtUsername.ForeColor = Color.Yellow;
            txtUsername.Location = new Point(121, 562);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(931, 27);
            txtUsername.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 569);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 18;
            label5.Text = "Username";
            // 
            // cbmChats
            // 
            cbmChats.BackColor = Color.FromArgb(0, 2, 85);
            cbmChats.ForeColor = Color.Yellow;
            cbmChats.FormattingEnabled = true;
            cbmChats.Location = new Point(77, 699);
            cbmChats.Name = "cbmChats";
            cbmChats.Size = new Size(980, 28);
            cbmChats.TabIndex = 19;
            cbmChats.SelectedIndexChanged += cbmChats_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 673);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 20;
            label6.Text = "Users:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 707);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 21;
            label7.Text = "Chats:";
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 2, 85);
            ClientSize = new Size(1064, 739);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cbmChats);
            Controls.Add(label5);
            Controls.Add(txtUsername);
            Controls.Add(cmbUsers);
            Controls.Add(btnGetColorMessage);
            Controls.Add(rtbChat);
            Controls.Add(btnStart);
            Controls.Add(btnCreateUser);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(txtRemotePort);
            Controls.Add(txtIp);
            Controls.Add(txtLocalPort);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ForeColor = Color.Yellow;
            Name = "FormClient";
            Text = "TCPClient";
            FormClosing += FormClient_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtLocalPort;
        private TextBox txtIp;
        private TextBox txtRemotePort;
        private TextBox txtMessage;
        private Button btnSend;
        private Button btnCreateUser;
        private Button btnStart;
        private RichTextBox rtbChat;
        private ColorDialog colorDialog1;
        private Button btnGetColorMessage;
        private ComboBox cmbUsers;
        private TextBox txtUsername;
        private Label label5;
        private ComboBox cbmChats;
        private Label label6;
        private Label label7;
    }
}
