namespace test_tcp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            SendForm sendForm = new SendForm();
            sendForm.Show();
            this.Hide();
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            ReceiveForm receiveForm = new ReceiveForm();
            receiveForm.Show();
            this.Hide();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
