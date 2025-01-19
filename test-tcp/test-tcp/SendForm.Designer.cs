namespace test_tcp
{
    partial class SendForm
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
            txtIpAddress = new TextBox();
            btnConnect = new Button();
            lblStatus = new Label();
            txtMessage = new TextBox();
            btnSendData = new Button();
            lblMessageStatus = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtIpAddress
            // 
            txtIpAddress.Location = new Point(344, 111);
            txtIpAddress.Name = "txtIpAddress";
            txtIpAddress.Size = new Size(118, 23);
            txtIpAddress.TabIndex = 0;
            txtIpAddress.Text = "Enter IP Address";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(357, 183);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(464, 183);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 6;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(256, 282);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(284, 30);
            txtMessage.TabIndex = 4;
            txtMessage.Text = "Enter a message to send";
            // 
            // btnSendData
            // 
            btnSendData.Location = new Point(357, 347);
            btnSendData.Name = "btnSendData";
            btnSendData.Size = new Size(75, 23);
            btnSendData.TabIndex = 5;
            btnSendData.Text = "Send";
            btnSendData.UseVisualStyleBackColor = true;
            btnSendData.Click += btnSendData_Click;
            // 
            // lblMessageStatus
            // 
            lblMessageStatus.AutoSize = true;
            lblMessageStatus.Location = new Point(546, 282);
            lblMessageStatus.Name = "lblMessageStatus";
            lblMessageStatus.Size = new Size(0, 15);
            lblMessageStatus.TabIndex = 7;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // SendForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(lblMessageStatus);
            Controls.Add(btnSendData);
            Controls.Add(txtMessage);
            Controls.Add(lblStatus);
            Controls.Add(btnConnect);
            Controls.Add(txtIpAddress);
            Name = "SendForm";
            Text = "SendForm";
            FormClosing += SendForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIpAddress;
        private Button btnConnect;
        private Label lblStatus;
        private TextBox txtMessage;
        private Button btnSendData;
        private Label lblMessageStatus;
        private Button btnBack;
    }
}