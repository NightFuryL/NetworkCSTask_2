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
            btnConnect = new Button();
            btnSend = new Button();
            btnDisconnect = new Button();
            label1 = new Label();
            label2 = new Label();
            txtMessage = new TextBox();
            txtAnswer = new TextBox();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.FromArgb(0, 2, 85);
            btnConnect.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConnect.ForeColor = Color.Yellow;
            btnConnect.Location = new Point(12, 118);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(135, 29);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(0, 2, 85);
            btnSend.Enabled = false;
            btnSend.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSend.ForeColor = Color.Yellow;
            btnSend.Location = new Point(153, 118);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(141, 29);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.BackColor = Color.FromArgb(0, 2, 85);
            btnDisconnect.Enabled = false;
            btnDisconnect.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDisconnect.ForeColor = Color.Yellow;
            btnDisconnect.Location = new Point(300, 118);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(135, 29);
            btnDisconnect.TabIndex = 2;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = false;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 2, 85);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 3;
            label1.Text = "Message";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 2, 85);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "Answer:";
            // 
            // txtMessage
            // 
            txtMessage.BackColor = Color.FromArgb(0, 2, 85);
            txtMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtMessage.ForeColor = Color.Yellow;
            txtMessage.Location = new Point(12, 32);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(423, 27);
            txtMessage.TabIndex = 5;
            // 
            // txtAnswer
            // 
            txtAnswer.BackColor = Color.FromArgb(0, 2, 85);
            txtAnswer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtAnswer.ForeColor = Color.Yellow;
            txtAnswer.Location = new Point(12, 85);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(423, 27);
            txtAnswer.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 2, 85);
            ClientSize = new Size(447, 156);
            Controls.Add(txtAnswer);
            Controls.Add(txtMessage);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDisconnect);
            Controls.Add(btnSend);
            Controls.Add(btnConnect);
            Name = "FormClient";
            Text = "TCPClient";
            FormClosing += FormClient_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private Button btnSend;
        private Button btnDisconnect;
        private Label label1;
        private Label label2;
        private TextBox txtMessage;
        private TextBox txtAnswer;
    }
}
