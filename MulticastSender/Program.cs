using System.Net;
using System.Net.Sockets;
using System.Text;
namespace MulticastSender;
public class Program
{
    static void Main(string[] args)
    {
        string multicastIpStr = "229.0.0.222";
        IPAddress multicastIp = IPAddress.Parse(multicastIpStr);
        int port = 9050;

        using UdpClient sender = new UdpClient();
        sender.JoinMulticastGroup(multicastIp);
        IPEndPoint groupEp = new IPEndPoint(multicastIp, port);

        while (true)
        {
            Console.WriteLine("Enter multicast message: ");
            string message = Console.ReadLine();
            byte[] data = Encoding.UTF8.GetBytes(message);
            sender.Send(data, groupEp);
        }
    }
}
