using System.Net;
using System.Net.Sockets;
using System.Text;

namespace BroadcastReceiver;
public class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        const int port = 9050;

        using UdpClient receiver = new UdpClient(port);
        IPEndPoint remoteEp = new IPEndPoint(IPAddress.Any, port);

        Console.WriteLine($"Broadcast receiver is running on port {port}. Waiting for message ... ");
        while (true)
        {
            byte[] buffer = receiver.Receive(ref remoteEp);
            string message = Encoding.UTF8.GetString(buffer);
            Console.WriteLine($"Received broadcast message: {message}");
        }
    }
}
