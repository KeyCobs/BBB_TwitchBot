using System.Net.Sockets;

var tcpClient = new TcpClient();
await tcpClient.ConnectAsync(ip,port);