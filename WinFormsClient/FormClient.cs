using System.Net;
using System.Net.Sockets;
namespace WinFormsClient;
public partial class FormClient : Form
{
    private TcpClient _client = null!;
    private IPAddress _ipAddress = IPAddress.Loopback;
    private const int SERVER_PORT = 9999;
    public FormClient()
    {
        InitializeComponent();
        _client = new TcpClient();
    }
    private async void btnConnect_Click(object sender, EventArgs e)
    {
        try
        {
            if (_client.Connected)
            {
                MessageBox.Show("Already connected to server.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (_client.Client == null)
            {
                _client = new TcpClient();
            }
            await _client.ConnectAsync(_ipAddress, SERVER_PORT);

            //MessageBox.Show($"Connected to server: {_client.Client.RemoteEndPoint}");

            btnConnect.Enabled = false;
            btnSend.Enabled = true;
            btnDisconnect.Enabled = true; ;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Connection error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnSend_Click(object sender, EventArgs e)
    {
        try
        {
            string message = "GET";
            byte[] data = System.Text.Encoding.UTF8.GetBytes(message);
            await _client.GetStream().WriteAsync(data, 0, data.Length);

            byte[] buffer = new byte[4096];
            int bytesRead = await _client.GetStream().ReadAsync(buffer, 0, buffer.Length);

            string answer = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);
            txtAnswer.Text = answer;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error sending message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private async void btnDisconnect_Click(object sender, EventArgs e)
    {
        await Disconnect();

        btnConnect.Enabled = true;
        btnSend.Enabled = false;
        btnDisconnect.Enabled = false;
    }
    private async void FormClient_FormClosing(object sender, FormClosingEventArgs e)
    {
        await Disconnect();
    }
    private async Task Disconnect()
    {
        try
        {
            if (_client != null && _client.Connected)
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes("DISCONNECT");

                await _client.GetStream().WriteAsync(data, 0, data.Length);

                _client.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Disconnect error: {ex.Message}");
        }
    }
}
