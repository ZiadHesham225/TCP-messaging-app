namespace test_tcp
{
    partial class ReceiveForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtServerIpAddress = new TextBox();
            btnStartListening = new Button();
            lblStatus = new Label();
            txtReceivedMessage = new TextBox();
            Msg = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtServerIpAddress
            // 
            txtServerIpAddress.Location = new Point(328, 75);
            txtServerIpAddress.Name = "txtServerIpAddress";
            txtServerIpAddress.ReadOnly = true;
            txtServerIpAddress.Size = new Size(100, 23);
            txtServerIpAddress.TabIndex = 0;
            // 
            // btnStartListening
            // 
            btnStartListening.Location = new Point(318, 160);
            btnStartListening.Name = "btnStartListening";
            btnStartListening.Size = new Size(119, 23);
            btnStartListening.TabIndex = 2;
            btnStartListening.Text = "Start Connection";
            btnStartListening.UseVisualStyleBackColor = true;
            btnStartListening.Click += btnStartListening_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(500, 160);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 3;
            // 
            // txtReceivedMessage
            // 
            txtReceivedMessage.Location = new Point(224, 304);
            txtReceivedMessage.Multiline = true;
            txtReceivedMessage.Name = "txtReceivedMessage";
            txtReceivedMessage.ReadOnly = true;
            txtReceivedMessage.Size = new Size(399, 65);
            txtReceivedMessage.TabIndex = 4;
            // 
            // Msg
            // 
            Msg.AutoSize = true;
            Msg.Location = new Point(165, 307);
            Msg.Name = "Msg";
            Msg.Size = new Size(53, 15);
            Msg.TabIndex = 5;
            Msg.Text = "Message";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ReceiveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(Msg);
            Controls.Add(txtReceivedMessage);
            Controls.Add(lblStatus);
            Controls.Add(btnStartListening);
            Controls.Add(txtServerIpAddress);
            Name = "ReceiveForm";
            Text = "ReceiveForm";
            FormClosing += ReceiveForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtServerIpAddress;
        private Button btnStartListening;
        private Label lblStatus;
        private TextBox txtReceivedMessage;
        private Label Msg;
        private Button btnBack;
    }
}