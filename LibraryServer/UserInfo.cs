namespace LibraryServer;
public class UserInfo
{
    public string UserName { get; set; } = string.Empty;
    public string IpAddress { get; set; } = string.Empty;
    public int Port { get; set; }
    public override string ToString()
    {
        return $"{UserName} ({IpAddress}:{Port})";
    }
    public string GetFileName()
    {
        return $"{UserName}_{IpAddress}_{Port}.json";
    }
}