using System.Text.Json;
namespace LibraryServer;
//В цій ситуації я зберігаю список користовучів АЛЕ
//їх насправді не треба просто так простіше
public static class ClientManager
{
    private static string _folderChat = "..\\chats";

    private static string _folderUsers = "..\\users";

    static ClientManager()
    {
        if (!Directory.Exists(_folderChat))
        {
            Directory.CreateDirectory(_folderChat);
        }

        if (!Directory.Exists(_folderUsers))
        {
            Directory.CreateDirectory(_folderUsers);
        }
    }

    public static void SaveUser(UserInfo user)
        => SaveObject(user, _folderUsers, user.GetFileName());

    public static void SaveChat(ChatHistory history)
        => SaveObject(
            history,
            _folderChat,
            history.RemoteUser.GetFileName());

    public static UserInfo? LoadUser(string fileName)
        => LoadObject<UserInfo>(_folderUsers, fileName);

    public static ChatHistory? LoadChat(string fileName)
        => LoadObject<ChatHistory>(_folderChat, fileName);

    public static List<UserInfo> GetAllUsers()
        => LoadAllObjects<UserInfo>(_folderUsers);

    public static List<ChatHistory> GetAllChats()
        => LoadAllObjects<ChatHistory>(_folderChat);
    public static void AppendMessage(UserInfo user, ChatMessage message)
    {
        ChatHistory? history = LoadChat(user.GetFileName());
        if (history == null)
        {
            history = new ChatHistory
            {
                RemoteUser = user
            };
        }
        history.Messages.Add(message);
        SaveChat(history);
    }
    private static void SaveObject<T>(T obj, string folder, string fileName)
    {
        string path = Path.Combine(folder, fileName);
        string json = JsonSerializer.Serialize(obj, new JsonSerializerOptions{ WriteIndented = true});
        File.WriteAllText(path, json);
    }

    private static T? LoadObject<T>(string folder, string fileName)
    {
        string path = Path.Combine(folder, fileName);
        if (!File.Exists(path)) return default;
        string json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<T>(json);
    }

    private static List<T> LoadAllObjects<T>(string folder)
    {
        return Directory
            .GetFiles(folder, "*.json")
            .Select(file =>
                LoadObject<T>(
                    folder,
                    Path.GetFileName(file))!)
            .Where(x => x != null)
            .ToList()!;
    }
}