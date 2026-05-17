using System.Text.Json;
namespace LibraryServer;
public class ChatMessage
{
    public UserInfo Sender { get; set; } = new();

    public string Text { get; set; } = string.Empty;
    public DateTime Time { get; set; } = DateTime.Now;
    public int ArgbColor { get; set; }
    public string ToJson()
    {
        return JsonSerializer.Serialize(this);
    }
    public static ChatMessage? FromJson(string json)
    {
        return JsonSerializer.Deserialize<ChatMessage>(json);
    }
    public override string ToString()
    {
        return $"[{Time:HH:mm}] [{Sender.UserName}]: {Text}";
    }
}