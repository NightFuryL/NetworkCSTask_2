using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MulticastReceiver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string multicastIpStr = "229.0.0.222";
            IPAddress multicastIp = IPAddress.Parse(multicastIpStr);
            int port = 9050;

            using UdpClient receiver = new UdpClient(port);
            receiver.JoinMulticastGroup(multicastIp);
            IPEndPoint remoteEp = new IPEndPoint(IPAddress.Any, 0);

            Console.WriteLine($"Multicast receiver is running on port {port}. Waiting for messages ... ");

            while (true)
            { 
                byte[] buffer = receiver.Receive(ref remoteEp);
                string message = Encoding.UTF8.GetString(buffer);
                Console.WriteLine($"Received multicast message: {message}");
            }
        }
    }
}
