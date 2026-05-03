using System.Net.Sockets;
namespace LibraryTask;
public class User
{
    //так саме і там і там публічнйи модифікатор
    public string Name { get; set; } = string.Empty;
    public Socket OwnSocket { get; set; } = null!;
    public User(string name, Socket socket)
    {
        Name = name;
        OwnSocket = socket;
    }
    public User() { }
}
