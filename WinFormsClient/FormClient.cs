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

            MessageBox.Show($"Connected to server: {_client.Client.RemoteEndPoint}");

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
            string message = txtMessage.Text.Trim();
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
    private void btnDisconnect_Click(object sender, EventArgs e)
    {
        Disconnect();

        btnConnect.Enabled = true;
        btnSend.Enabled = false;
        btnDisconnect.Enabled = false;
    }
    private void FormClient_FormClosing(object sender, FormClosingEventArgs e)
    {
        Disconnect();
    }
    private void Disconnect()
    {
        if (_client.Connected)
        {
            _client.Close();
            MessageBox.Show("Disconnected from server.");
        }
    }
}
