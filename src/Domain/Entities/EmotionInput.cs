namespace InvisibleEmotionDetector.Domain.Entities;

public class EmotionInput
{
    public Guid Id { get; set; }
    public string Emotion { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime Timestamp { get; set; }
    public Guid UserId { get; set; }

    public User? User { get; set; }
}
