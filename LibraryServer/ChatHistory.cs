//простий клас для збереження історії чатів з конкретним користувачем
namespace LibraryServer;
public class ChatHistory
{
    public UserInfo RemoteUser { get; set; } = new();
    public List<ChatMessage> Messages { get; set; } = new();
    public override string ToString()
    {
        return RemoteUser.ToString();
    }
}