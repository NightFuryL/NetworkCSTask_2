using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleTask;

public class Program
{
    
    private static async Task Main(string[] args)
    {
        using Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        int localPort = 9090;
        IPAddress localIp = IPAddress.Any;
        IPEndPoint localEp = new IPEndPoint(localIp, localPort);
        server.Bind(localEp);

        server.Listen();
        while (true) { 
            Socket client = await server.AcceptAsync();
            _ = Task.Run(() => HandleClientAsync(client));
        }

    }

    private static async void HandleClientAsync(Socket client)
    {
        try
        {
            byte[] buffer = new byte[1024];
            while (true)
            {
                int bytes = await client.ReceiveAsync(buffer);
                if (bytes == 0) break;
                string data = Encoding.UTF8.GetString(buffer, 0, bytes);
                Console.WriteLine($"Client ({client.RemoteEndPoint}) message: {data}");
                string answer = "Echo: " + data;
                byte[] answerData = Encoding.UTF8.GetBytes(answer);
                await client.SendAsync(answerData);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine($"ERROR: {ex.ToString()}");
        }
        client.Close();
    }
}
