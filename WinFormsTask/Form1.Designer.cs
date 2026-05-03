namespace WinFormsTask
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
            label1 = new Label();
            label2 = new Label();
            btnConnect = new Button();
            btnSend = new Button();
            btnDisconnect = new Button();
            txtMessage = new TextBox();
            txtAnswer = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Message:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Navy;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Answer:";
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.DarkBlue;
            btnConnect.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConnect.ForeColor = Color.Yellow;
            btnConnect.Location = new Point(12, 78);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(776, 29);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.DarkBlue;
            btnSend.Enabled = false;
            btnSend.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSend.ForeColor = Color.Yellow;
            btnSend.Location = new Point(12, 113);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(776, 29);
            btnSend.TabIndex = 3;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.BackColor = Color.DarkBlue;
            btnDisconnect.Enabled = false;
            btnDisconnect.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDisconnect.ForeColor = Color.Yellow;
            btnDisconnect.Location = new Point(12, 148);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(776, 29);
            btnDisconnect.TabIndex = 4;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = false;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // txtMessage
            // 
            txtMessage.BackColor = Color.Navy;
            txtMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtMessage.ForeColor = Color.Yellow;
            txtMessage.Location = new Point(88, 12);
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = "Type some text...";
            txtMessage.Size = new Size(700, 27);
            txtMessage.TabIndex = 5;
            // 
            // txtAnswer
            // 
            txtAnswer.BackColor = Color.Navy;
            txtAnswer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtAnswer.ForeColor = Color.Yellow;
            txtAnswer.Location = new Point(88, 45);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.ReadOnly = true;
            txtAnswer.Size = new Size(700, 27);
            txtAnswer.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(800, 188);
            Controls.Add(txtAnswer);
            Controls.Add(txtMessage);
            Controls.Add(btnDisconnect);
            Controls.Add(btnSend);
            Controls.Add(btnConnect);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnConnect;
        private Button btnSend;
        private Button btnDisconnect;
        private TextBox txtMessage;
        private TextBox txtAnswer;
    }
}
