using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;
using System.Diagnostics;

namespace test_tcp
{
    public class SenderService
    {
        private TcpClient tcpClient;
        private NetworkStream stream;
        private CancellationTokenSource cancellationTokenSource;
        public bool IsConnected => tcpClient?.Connected ?? false;

        public async Task ConnectAsync(string ipAddress, int port)
        {
            cancellationTokenSource = new CancellationTokenSource();
            if (tcpClient != null && IsConnected)
                throw new InvalidOperationException("Already connected.");

            if (!IPAddress.TryParse(ipAddress, out _))
                throw new FormatException("IP address format is invalid.");

            try
            {
                tcpClient = new TcpClient();
                await tcpClient.ConnectAsync(IPAddress.Parse(ipAddress), port,cancellationTokenSource.Token);
                stream = tcpClient.GetStream();
            }
            catch (SocketException)
            {
                throw new Exception("Unable to connect to the specified IP address.");
            }
        }

        public async Task SendMessageAsync(string message)
        {
            if (!IsConnected)
                throw new InvalidOperationException("Not connected to a server.");

            byte[] data = Encoding.ASCII.GetBytes(message);
            await stream.WriteAsync(data, 0, data.Length);
        }

        public void Disconnect(Action onDisconnected)
        {
            cancellationTokenSource?.Cancel();
            cancellationTokenSource?.Dispose();
            if (tcpClient != null && tcpClient.Connected)
            {
                stream.Close();
                tcpClient.Close();
            }
  
            onDisconnected?.Invoke();
        }

        public void StartConnectionMonitor(Action onDisconnected)
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    try
                    {
                        if (!Connected(tcpClient))
                        {
                            onDisconnected?.Invoke();
                        }
                        Debug.WriteLine(tcpClient.Connected);
                        await Task.Delay(1000);
                    }
                    catch (Exception)
                    {
                        onDisconnected?.Invoke();
                        break;
                    }
                }
            });
        }
        bool Connected(TcpClient client)
        {
            try
            {
                if (client.Client != null && client.Client.Connected)
                {
                    return !(client.Client.Poll(1, SelectMode.SelectRead) && client.Client.Available == 0);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

    }
}
