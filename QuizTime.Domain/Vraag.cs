namespace QuizTime.Domain;

public class Vraag
{
    public long Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public List<string> Antwoorden { get; set; } = new List<string>();
    public string? CorrectAntwoord { get; set; }
}