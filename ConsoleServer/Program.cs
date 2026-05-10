using System.Net;
using System.Net.Sockets;
namespace ConsoleServer;
internal class Program
{
    private const int SERVER_PORT = 9999;
    private static IPEndPoint _serverEp;
    private static IPAddress _serverIp;
    static async Task Main(string[] args)
    {
        _serverIp = IPAddress.Any;
        _serverEp = new IPEndPoint(_serverIp, SERVER_PORT);

        using TcpListener server = new TcpListener(_serverEp);

        server.Start();
        Console.WriteLine($"Server is running: {server.LocalEndpoint}");

        while (true)
        {
            TcpClient client = await server.AcceptTcpClientAsync();
            Console.WriteLine($"Client connected: {client.Client.RemoteEndPoint}");
            _ = Task.Run(() => HandleClientAsync(client));
        }
    }
    private static async Task HandleClientAsync(TcpClient client)
    {
        NetworkStream stream = client.GetStream();
        try
        {
            while (true)
            {
                byte[] buffer = new byte[4096];
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                if (bytesRead == 0) break;
                string message = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine($"New message from {client.Client.RemoteEndPoint}: {message}");

                string answer =$"ECHO: {message}";
                byte[] response = System.Text.Encoding.UTF8.GetBytes(answer);
                await stream.WriteAsync(response);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ERROR: {ex.Message}");
        }
        finally
        {
            
            stream.Close();
            client.Close();
            Console.WriteLine($"Client disconnected: {client.Client.RemoteEndPoint}");
        }
    }
}