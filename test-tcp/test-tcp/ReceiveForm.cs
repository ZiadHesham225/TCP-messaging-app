using System;
using System.Windows.Forms;

namespace test_tcp
{
    public partial class ReceiveForm : Form
    {
        private ReceiverService receiverService;

        public ReceiveForm()
        {
            receiverService = new ReceiverService();
            InitializeComponent();
            txtServerIpAddress.ReadOnly = true;
            txtServerIpAddress.Text = GetLocalIPAddress();
            lblStatus.Text = "";
        }

        private async void btnStartListening_Click(object sender, EventArgs e)
        {
            if (receiverService.IsListening)
            {
                receiverService.StopListening();
                UpdateStatus("Disconnected.");
                UpdateUIListeningState(false);
            }
            else
            {
                try
                {
                    UpdateUIListeningState(true);
                    UpdateStatus("Waiting for connections...");
                    await receiverService.StartListeningAsync(5000, OnClientConnected, OnMessageReceived);
                    UpdateStatus("Connected!");
                    UpdateUIListeningState(true);
                }
                catch (Exception)
                {
                    UpdateStatus("Disconnected!");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            receiverService.StopListening();
            NavigateToMainForm();
        }

        private void ReceiveForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private string GetLocalIPAddress()
        {
            return receiverService.LocalIPAddress;
        }

        private void OnClientConnected()
        {
            UpdateStatus("Client connected!");
        }

        private void OnMessageReceived(string message)
        {
            txtReceivedMessage.Invoke((MethodInvoker)(() => txtReceivedMessage.Text = message));
        }

        private void UpdateStatus(string message)
        {
            lblStatus.Invoke((MethodInvoker)(() => lblStatus.Text = message));
        }

        private void UpdateUIListeningState(bool isListening)
        {
            Invoke((MethodInvoker)(() =>
            {
                btnStartListening.Text = isListening ? "Stop Connection" : "Start Connection";
            }));
        }

        private void NavigateToMainForm()
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }
    }
}
