namespace ClientWinFormsTask
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
            btnConnect = new Button();
            txtUsername = new TextBox();
            txtChat = new TextBox();
            label1 = new Label();
            btnSend = new Button();
            btnRefresh = new Button();
            txtMessage = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnDisconnect = new Button();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.Navy;
            btnConnect.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConnect.ForeColor = Color.Yellow;
            btnConnect.Location = new Point(14, 78);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(1075, 29);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Navy;
            txtUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtUsername.ForeColor = Color.Yellow;
            txtUsername.Location = new Point(115, 12);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(973, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtChat
            // 
            txtChat.BackColor = Color.Navy;
            txtChat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtChat.ForeColor = Color.Yellow;
            txtChat.Location = new Point(14, 238);
            txtChat.Multiline = true;
            txtChat.Name = "txtChat";
            txtChat.ReadOnly = true;
            txtChat.ScrollBars = ScrollBars.Vertical;
            txtChat.Size = new Size(1074, 430);
            txtChat.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(14, 19);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Navy;
            btnSend.Enabled = false;
            btnSend.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSend.ForeColor = Color.Yellow;
            btnSend.Location = new Point(14, 113);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(1075, 29);
            btnSend.TabIndex = 4;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Navy;
            btnRefresh.Enabled = false;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.Yellow;
            btnRefresh.Location = new Point(14, 148);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(1075, 29);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtMessage
            // 
            txtMessage.BackColor = Color.Navy;
            txtMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtMessage.ForeColor = Color.Yellow;
            txtMessage.Location = new Point(115, 45);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(973, 27);
            txtMessage.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(14, 52);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 7;
            label2.Text = "Message:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(466, 215);
            label3.Name = "label3";
            label3.Size = new Size(182, 20);
            label3.TabIndex = 8;
            label3.Text = "BEST UKRAINIAN CHAT ";
            // 
            // btnDisconnect
            // 
            btnDisconnect.BackColor = Color.Navy;
            btnDisconnect.Enabled = false;
            btnDisconnect.Location = new Point(15, 183);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(1074, 29);
            btnDisconnect.TabIndex = 9;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = false;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1101, 680);
            Controls.Add(btnDisconnect);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMessage);
            Controls.Add(btnRefresh);
            Controls.Add(btnSend);
            Controls.Add(label1);
            Controls.Add(txtChat);
            Controls.Add(txtUsername);
            Controls.Add(btnConnect);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ForeColor = Color.Yellow;
            Name = "Form1";
            Text = "BEST UKRAINIAN CHAT ";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private TextBox txtUsername;
        private TextBox txtChat;
        private Label label1;
        private Button btnSend;
        private Button btnRefresh;
        private TextBox txtMessage;
        private Label label2;
        private Label label3;
        private Button btnDisconnect;
    }
}
