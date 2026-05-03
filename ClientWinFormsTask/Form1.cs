using LibraryTask;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClientWinFormsTask;

public partial class Form1 : Form
{
    private int _remotePort = 9090;
    private IPAddress _remoteIp = IPAddress.Loopback;
    private User _user = new User();
    private LibraryTask.Message _message = new LibraryTask.Message();
    public Form1()
    {
        InitializeComponent();
    }
    private async void btnConnect_Click(object sender, EventArgs e)
    {
        _user = new User()
        {
            Name = txtUsername.Text,
            OwnSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        };
        IPEndPoint endPoint = new IPEndPoint(_remoteIp, _remotePort);
        try
        {
            await _user.OwnSocket.ConnectAsync(endPoint);

            byte[] userData = Encoding.UTF8.GetBytes(_user.Name);
            await _user.OwnSocket.SendAsync(userData);

            MessageBox.Show("Connected to the chat!", "Connection successful");
            PrintMessage($"Welcome, {_user.Name}!");

            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            btnRefresh.Enabled = true;
            btnSend.Enabled = true;
        }
        catch(Exception ex)
        {
            MessageBox.Show($"ERROR: {ex.Message}", "Connection error");
        }
    }
    private async void btnSend_Click(object sender, EventArgs e)
    {
        try
        {
            _message = new LibraryTask.Message()
            {
                Sender = _user.Name,
                Text = txtMessage.Text
            };

            byte[] data = Encoding.UTF8.GetBytes(_message.Text);
            await _user.OwnSocket.SendAsync(data);

            PrintMessage(_message.FormattedMessage);

            txtMessage.Clear();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"ERROR: {ex.Message}", "Send error");
        }
    }
    //Цей метод трохи подвився в інтернеті бо в мене не получалось чогось зробити це все
    private async void btnRefresh_Click(object sender, EventArgs e)
    {
        try
        {
            byte[] request = Encoding.UTF8.GetBytes("GET");
            await _user.OwnSocket.SendAsync(request);

            byte[] buffer = new byte[4096];
            int receivedBytes = await _user.OwnSocket.ReceiveAsync(buffer);

            string response = Encoding.UTF8.GetString(buffer, 0, receivedBytes);

            txtChat.Clear();
            PrintMessage(response);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"ERROR: {ex.Message}", "Refresh error");
        }
    }
    private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            if (_user.OwnSocket != null && _user.OwnSocket.Connected)
            {
                byte[] data = Encoding.UTF8.GetBytes("EXIT");
                await _user.OwnSocket.SendAsync(data);
                _user.OwnSocket.Close();
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show($"ERROR: {ex.Message}", "Closing error");
        }
    }
    private async void btnDisconnect_Click(object sender, EventArgs e)
    {
        try
        {
            byte[] data = Encoding.UTF8.GetBytes("EXIT");
            await _user.OwnSocket.SendAsync(data);

            PrintMessage($"{_user.Name} disconnected");

            _user.OwnSocket.Close();

            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            btnSend.Enabled = false;
            btnRefresh.Enabled = false;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"ERROR: {ex.Message}", "Disconnect error");
        }
    }
    //Допоміжний метод для вивду повідомлень
    private void PrintMessage(string message)
    {
        if (txtChat.InvokeRequired)
        {
            txtChat.Invoke(new Action<string>(PrintMessage), message);
        }
        else
        {
            txtChat.AppendText(message + Environment.NewLine);
        }
    }
}
