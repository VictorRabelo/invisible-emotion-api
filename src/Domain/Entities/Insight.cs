namespace InvisibleEmotionDetector.Domain.Entities;

public class Insight
{
    public Guid Id { get; set; }
    public string Message { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public Guid UserId { get; set; }
    public User? User { get; set; }
}
