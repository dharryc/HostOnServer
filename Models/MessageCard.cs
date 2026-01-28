namespace operationswithwebservers_dharryc.Models;

public class MessageCard
{
    public int Id { get; set; }
    public string Author { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
