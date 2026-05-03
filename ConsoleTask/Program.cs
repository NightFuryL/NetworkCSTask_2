using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleTask;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            //1. Create
            using Socket server = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp);

            //2. Bind
            IPAddress serverIP = IPAddress.Any;
            int port = 9090;
            IPEndPoint localEP = new IPEndPoint(serverIP, port);
            server.Bind(localEP);

            //3. Listen
            server.Listen(5);

            //4. Accept
            using Socket client = server.Accept(); //Клієнтський сокет 
            Console.WriteLine($"New client: {client.RemoteEndPoint}");
            string greeting = "Hello from server!!!";
            byte[] data = Encoding.UTF8.GetBytes(greeting);

            //5. Send & Recieve
            client.Send(data);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ERROR: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Server shut down!");
            //6. Close
            //server.Close();
            //client.Close();
        }
    }
}
