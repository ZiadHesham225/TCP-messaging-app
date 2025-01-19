# TCP Client-Server Application

## Description
This is a simple TCP client-server application built using C# and WinForms, with added multithreading for handling multiple connections simultaneously. The app allows two devices to connect over a network, where one acts as a server and the other as a client. The client can send a message to the server, and the server can display the received message. The server is designed to handle multiple client connections at the same time using multithreading, ensuring that each client can interact with the server independently without blocking the others.

### Key Features:
- **Client-Server Communication:** One device acts as the client, and the other as the server. The client sends a message, and the server receives and displays it.
- **Multithreading Support:** The server uses multithreading to handle multiple clients simultaneously. Each client is managed on a separate thread, allowing the server to interact with multiple clients at once without blocking other connections.
- **Dynamic IP Entry:** Users can enter the IP address of the other device to establish a connection.
- **User-friendly Interface:** The app uses a WinForms UI to manage connections and display messages.
- **Real-time Status:** Shows the connection status on both devices once the connection is established.
- **Error Handling:** Includes basic error handling for invalid IP formats and unreachable IPs.
- **Non-blocking UI:** The client and server UI remain responsive even when multiple connections are being processed, thanks to the use of asynchronous operations and multithreading.



## Requirements:
- .NET Framework
- Two devices connected to the same network.


