using System.Net;
using System.Net.Sockets;
using System.Text;
namespace BroadcastSender;
public class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        const int remotePort = 9050;

        using UdpClient sender = new UdpClient();
        sender.EnableBroadcast = true;

        while (true)
        {
            Console.WriteLine("Enter broadcast message: ");
            string message = Console.ReadLine() ?? "Hello! This is broadcast message!";
            byte[] data = Encoding.UTF8.GetBytes(message);

            IPEndPoint broadcastEp = new IPEndPoint(IPAddress.Broadcast, remotePort);
            sender.Send(data, broadcastEp);

            Console.WriteLine("Broadcast message has been sent");
        }
    }
}
