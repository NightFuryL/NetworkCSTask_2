namespace LibraryTask;
public class Message
{
    public string Sender { get; set; } = null!;
    public string Text { get; set; } = null!;
    //Доп метод утиліта
    public string FormattedMessage => $"[{Sender}]: {Text}";
}
