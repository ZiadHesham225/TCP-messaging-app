using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_tcp
{
    public partial class SendForm : Form
    {
        private SenderService senderService;
        bool isConnectedbtn = false;
        public SendForm()
        {
            InitializeComponent();
            lblStatus.Text = "";
            senderService = new SenderService();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            if (isConnectedbtn)
            {
                Disconnect();
                isConnectedbtn = false;
            }
            else
            {
                isConnectedbtn = true;
                await ConnectToServer();
            }
        }

        private async void btnSendData_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;
            await SendMessage(message);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Disconnect();
            NavigateToMainForm();
        }

        private void SendForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async Task ConnectToServer()
        {
            try
            {
                string ipAddress = txtIpAddress.Text;
                UpdateStatus("Connecting...");
                UpdateUIConnectedState(true);
                await senderService.ConnectAsync(ipAddress, 5000);
                UpdateStatus("Connected!");
                UpdateUIConnectedState(true);
                senderService.StartConnectionMonitor(() => Disconnect());
            }
            catch (FormatException)
            {
                UpdateStatus("IP is in incorrect format.");
            }
            catch (SocketException ex)
            {
                UpdateStatus($"Error: {ex.Message}");
            }
            catch (Exception)
            {
                UpdateStatus("Disconnected!");
                UpdateUIConnectedState(false);
            }
        }

        private void Disconnect()
        {
            senderService.Disconnect(() =>
            {
                UpdateStatus("Disconnected.");
                UpdateUIConnectedState(false);
                isConnectedbtn = false;
            });
        }

        private async Task SendMessage(string message)
        {
            try
            {
                await senderService.SendMessageAsync(message);
                UpdateMessageStatus("Message sent!");
            }
            catch (InvalidOperationException)
            {
                UpdateStatus("Not connected to server.");
            }
            catch (Exception ex)
            {
                UpdateStatus($"Error: {ex.Message}");
            }
        }

        private void UpdateStatus(string message)
        {
            lblStatus.Invoke((MethodInvoker)(() => lblStatus.Text = message));
        }

        private void UpdateMessageStatus(string message)
        {
            lblMessageStatus.Invoke((MethodInvoker)(() => lblMessageStatus.Text = message));
        }

        private void UpdateUIConnectedState(bool isConnected)
        {
            Invoke((MethodInvoker)(() =>
            {
                btnConnect.Text = isConnected ? "Stop connection" : "Connect";
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
