namespace InvisibleEmotionDetector.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;

    public ICollection<EmotionInput> EmotionInputs { get; set; } = new List<EmotionInput>();
}
