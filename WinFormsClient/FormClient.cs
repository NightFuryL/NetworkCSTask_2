//UdpReceiveResult проста обгортка для отримання даних для UDP
//Щоб почати користуватися треба спочатку додати/вибрати користувача 
//потім натиснути старт і можна відправляти повідомлення людині з якою хочемо спілкуватися
//Наразі це все локально тому і такий інтерфейс
//Синхронізація чату, кольорів повідомленнях, збереження історії все це є
using LibraryServer;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace WinFormsClient;

public partial class FormClient : Form
{
    private UdpClient _udpClient = null!;
    private UserInfo _currentUser = new();
    private Color _ownColor = Color.White;

    public FormClient()
    {
        InitializeComponent();
        LoadUsers();
    }

    private void FormClient_Load(object sender, EventArgs e)
    {
        btnSend.Enabled = false;
        btnGetColorMessage.Enabled = false;
        cbmChats.Enabled = false;
    }

    private void LoadUsers()
    {
        cmbUsers.Items.Clear();

        foreach (UserInfo user in ClientManager.GetAllUsers())
        {
            cmbUsers.Items.Add(user);
        }
    }

    private void LoadChats()
    {
        cbmChats.Items.Clear();

        foreach (ChatHistory chat in ClientManager.GetAllChats())
        {
            cbmChats.Items.Add(chat);
        }
    }

    private void btnCreateUser_Click(object sender, EventArgs e)
    {
        try
        {
            UserInfo user = new UserInfo
            {
                UserName = txtUsername.Text,
                IpAddress = txtIp.Text,
                Port = int.Parse(txtRemotePort.Text)
            };

            ClientManager.SaveUser(user);

            LoadUsers();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cmbUsers.SelectedItem == null)
        {
            return;
        }

        _currentUser = (UserInfo)cmbUsers.SelectedItem;

        btnStart.Enabled = true;

        LoadChats();

        cbmChats.Enabled = true;
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        try
        {
            int localPort = int.Parse(txtLocalPort.Text);

            _udpClient = new UdpClient(localPort);

            _ = Task.Run(ReceiveMessages);

            btnSend.Enabled = true;
            btnGetColorMessage.Enabled = true;

            MessageBox.Show("Client started");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private async void btnSend_Click(object sender, EventArgs e)
    {
        try
        {
            ChatMessage msg = new ChatMessage
            {
                Sender = _currentUser,
                Text = txtMessage.Text,
                ArgbColor = _ownColor.ToArgb()
            };

            string json = msg.ToJson();

            byte[] data = Encoding.UTF8.GetBytes(json);

            IPEndPoint remoteEp = new IPEndPoint(
                IPAddress.Parse(txtIp.Text),
                int.Parse(txtRemotePort.Text));

            await _udpClient.SendAsync(data, data.Length, remoteEp);

            UserInfo remoteUser = new UserInfo
            {
                IpAddress = remoteEp.Address.ToString(),
                Port = remoteEp.Port,
                UserName = "RemoteUser"
            };

            ClientManager.AppendMessage(remoteUser, msg);

            AddMessage(msg);

            txtMessage.Clear();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error sending message: {ex.Message}");
        }
    }

    private async Task ReceiveMessages()
    {
        while (true)
        {
            try
            {
                UdpReceiveResult result = await _udpClient.ReceiveAsync();

                string json = Encoding.UTF8.GetString(result.Buffer);

                ChatMessage? msg = ChatMessage.FromJson(json);

                if (msg != null)
                {
                    UserInfo remoteUser = new UserInfo
                    {
                        UserName = msg.Sender.UserName,
                        IpAddress = result.RemoteEndPoint.Address.ToString(),
                        Port = result.RemoteEndPoint.Port
                    };

                    ClientManager.AppendMessage(remoteUser, msg);

                    Invoke(() =>
                    {
                        AddMessage(msg);

                        LoadChats();
                    });
                }
            }
            catch
            {
                break;
            }
        }
    }

    private void AddMessage(ChatMessage msg)
    {
        rtbChat.SelectionColor = Color.FromArgb(msg.ArgbColor);

        rtbChat.AppendText(msg + Environment.NewLine);

        rtbChat.ScrollToCaret();
    }

    private void btnGetColorMessage_Click(object sender, EventArgs e)
    {
        ColorDialog colorDialog = new();

        if (colorDialog.ShowDialog() == DialogResult.OK)
        {
            _ownColor = colorDialog.Color;
        }
    }

    private void cbmChats_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbmChats.SelectedItem == null)
        {
            return;
        }

        ChatHistory history = (ChatHistory)cbmChats.SelectedItem;

        rtbChat.Clear();

        foreach (ChatMessage msg in history.Messages)
        {
            AddMessage(msg);
        }
    }

    private void FormClient_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            _udpClient?.Close();
        }
        catch
        {

        }
    }
}