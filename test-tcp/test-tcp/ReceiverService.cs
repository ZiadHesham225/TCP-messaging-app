using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace test_tcp
{
    public class ReceiverService
    {
        private TcpListener tcpListener;
        private TcpClient connectedClient;

        public bool IsListening { get; private set; }
        public string LocalIPAddress => GetLocalIPAddress();

        public async Task StartListeningAsync(int port, Action onClientConnected, Action<string> onMessageReceived)
        {
            if (IsListening)
                throw new InvalidOperationException("Already listening for connections.");

            tcpListener = new TcpListener(IPAddress.Parse(LocalIPAddress), port);
            tcpListener.Start();
            IsListening = true;

            connectedClient = await tcpListener.AcceptTcpClientAsync();
            onClientConnected?.Invoke();
            await HandleClientAsync(connectedClient, onMessageReceived);
        }

        private async Task HandleClientAsync(TcpClient client, Action<string> onMessageReceived)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;

            while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) != 0)
            {
                string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                onMessageReceived?.Invoke(message);
            }
        }

        public void StopListening()
        {
            if (tcpListener != null)
            {
                tcpListener.Stop();
            }

            if (connectedClient != null && connectedClient.Connected)
            {
                connectedClient.GetStream().Close();
                connectedClient.Close();
                connectedClient.Dispose();
            }
            IsListening = false;
        }

        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system.");
        }
    }
}
