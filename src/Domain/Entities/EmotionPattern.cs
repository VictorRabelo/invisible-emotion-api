namespace InvisibleEmotionDetector.Domain.Entities;

public class EmotionPattern
{
    public Guid Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public Guid UserId { get; set; }
    public User? User { get; set; }
}
