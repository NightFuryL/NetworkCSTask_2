using System.Net;
using System.Net.Sockets;
namespace ConsoleServer;
internal class Program
{
    private const int SERVER_PORT = 9999;
    private static IPEndPoint _serverEp;
    private static IPAddress _serverIp;

    private static List<string> _quotes = new List<string>()
    {
        "Knowledge is power.",
        "Stay hungry, stay foolish.",
        "Practice makes perfect.",
        "Never give up.",
        "Code is like humor.",
        "Dream big.",
        "Learning never stops."
    };

    static async Task Main(string[] args)
    {
        _serverIp = IPAddress.Any;
        _serverEp = new IPEndPoint(_serverIp, SERVER_PORT);

        using TcpListener server = new TcpListener(_serverEp);

        server.Start();

        Console.WriteLine($"[SERVER] Running: {server.LocalEndpoint}");

        while (true)
        {
            TcpClient client = await server.AcceptTcpClientAsync();
            Console.WriteLine($"[CLIENT][{DateTime.Now:F}] Connected: {client.Client.RemoteEndPoint}");
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
                if(message == "GET")
                {
                    string qoute = _quotes[Random.Shared.Next(_quotes.Count)];
                    string answer = $"Quote: {qoute}";
                    Console.WriteLine($"[SERVER]({DateTime.Now:F}) (({answer})) - {client.Client.RemoteEndPoint}");
                    byte[] response = System.Text.Encoding.UTF8.GetBytes(answer);
                    await stream.WriteAsync(response);
                }
                if (message == "DISCONNECT")
                {
                    Console.WriteLine($"[CLIENT]({DateTime.Now:F}) disconnected: {client.Client.RemoteEndPoint}");
                    break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[ERROR] {ex.Message}");
        }
        finally
        {
            
            stream.Close();
            client.Close();
            Console.WriteLine($"[CLIENT]({DateTime.Now:F}) disconnected: {client.Client.RemoteEndPoint}");
        }
    }
}