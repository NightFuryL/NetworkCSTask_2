using System.Net;
using System.Net.Sockets;
using System.Text;
namespace WinFormsTask;

public partial class Form1 : Form
{
    private Socket socket = null!;
    private int remotePort = 9090;
    private IPAddress remoteIp = IPAddress.Loopback;
    public Form1()
    {
        InitializeComponent();
    }

    private async void btnConnect_Click(object sender, EventArgs e)
    {
        socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPEndPoint remoteEp = new IPEndPoint(remoteIp, remotePort);
        try
        {
            await socket.ConnectAsync(remoteEp);

            MessageBox.Show("Connection successful!");

            btnConnect.Enabled = false;
            btnSend.Enabled = true;
            btnDisconnect.Enabled = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"ERROR: {ex.Message}");
        }

    }

    private async void btnSend_Click(object sender, EventArgs e)
    {
        if (socket == null || !socket.Connected) return;
        string message = txtMessage.Text;
        byte[] data = Encoding.UTF8.GetBytes(message);
        try
        {
            await socket.SendAsync(data);
            txtAnswer.Clear();
            byte[] buffer = new byte[1024];
            int bytesRead = 0;
            do
            {
                bytesRead = await socket.ReceiveAsync(buffer);
                string answered = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                txtAnswer.AppendText(answered);
            } while (bytesRead != 0);
        }
        catch(Exception ex)
        {
            MessageBox.Show($"ERROR: {ex.Message}");
        }
    }

    private async void btnDisconnect_Click(object sender, EventArgs e)
    {
        if (socket == null || !socket.Connected) return;
        await socket.DisconnectAsync(false);
        socket.Close();
        socket = null;

        MessageBox.Show("Disconnected!");
        btnConnect.Enabled = true;
        btnSend.Enabled = false;
        btnDisconnect.Enabled = false;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (socket == null) return;
        if (socket.Connected)
        {
            await socket.DisconnectAsync(false);
        }
        socket.Close();
    }
}
