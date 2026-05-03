using System.Net;
using System.Net.Sockets;
using System.Text;

namespace WinFormsTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //1. Create
            using Socket socket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                );
            try
            {
                //2. Connect
                IPAddress remoteIP = IPAddress.Loopback;
                int remotePort = 9090;
                IPEndPoint remote = new IPEndPoint(remoteIP, remotePort);
                //3. Send & Recieve
                byte[] buffer = new byte[1024];
                int bytesRead = 0;
                do
                {
                    bytesRead = socket.Receive(buffer);
                    string data = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    txtAnswer.AppendText(data);
                }
                while (bytesRead != 0);
            }
            catch (Exception ex) {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
            //4. Close
            //socket.Close();

        }

    }
}
