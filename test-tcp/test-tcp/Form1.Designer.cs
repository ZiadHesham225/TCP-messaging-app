namespace test_tcp
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
            btnSend = new Button();
            btnReceive = new Button();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(258, 163);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(116, 44);
            btnSend.TabIndex = 0;
            btnSend.Text = "Send Data";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnReceive
            // 
            btnReceive.Location = new Point(457, 163);
            btnReceive.Name = "btnReceive";
            btnReceive.Size = new Size(116, 44);
            btnReceive.TabIndex = 1;
            btnReceive.Text = "Receive Data";
            btnReceive.UseVisualStyleBackColor = true;
            btnReceive.Click += btnReceive_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReceive);
            Controls.Add(btnSend);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSend;
        private Button btnReceive;
    }
}
