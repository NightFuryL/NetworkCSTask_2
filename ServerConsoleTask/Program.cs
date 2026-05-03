using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Text;
using LibraryTask;

namespace ServerConsoleTask;

public class Program
{
    private static Socket _server;
    private static List<User> _users = new List<User>();
    //Також використовую асинхронну чергу щоб не було проблем з багатопоточністю
    private static ConcurrentQueue<LibraryTask.Message> _messages = new ConcurrentQueue<LibraryTask.Message>();

    static async Task Main(string[] args)
    {
        _server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 9090);
        _server.Bind(endPoint);
        _server.Listen(10);

        Console.WriteLine("Server is running...");
        while (true)
        {
            Socket client = await _server.AcceptAsync();
            _ = Task.Run(() => HandleClient(client));
        }
    }

    private static async Task HandleClient(Socket client)
    {
        byte[] buffer = new byte[1024];

        int bytesReceived = await client.ReceiveAsync(buffer);
        string username = Encoding.UTF8.GetString(buffer, 0, bytesReceived);

        User user = new User(username, client);
        _users.Add(user);

        _messages.Enqueue(new LibraryTask.Message
        {
            Sender = username,
            Text = "has joined the chat."
        });
        //також подивився в інтернеті як це можноо було зробити, саме командами GET та EXIT бо я думав так не можно було
        while (true)
        {
            bytesReceived = await client.ReceiveAsync(buffer);
            if (bytesReceived <= 0) break;
            string msg = Encoding.UTF8.GetString(buffer, 0, bytesReceived);
            if(msg == "GET")
            {
                string all = string.Join(Environment.NewLine, _messages.Select(m => m.FormattedMessage));
                byte[] data = Encoding.UTF8.GetBytes(all);
                await client.SendAsync(data);
            }
            else if(msg == "EXIT")
            {
                _messages.Enqueue(new LibraryTask.Message
                {
                    Sender = username,
                    Text = $"has left the chat."
                });
                _users.Remove(user);
                break;
            }
            else
            {
                _messages.Enqueue(new LibraryTask.Message
                {
                    Sender = username,
                    Text = msg
                });
            }
        }
        client.Close();
    }
}
