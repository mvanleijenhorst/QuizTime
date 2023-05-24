namespace QuizTime.Infra.JsonFile;

public class JsonFileQuestion
{
    public Guid Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public List<JsonFileAnswer> Answers { get; set; } = new List<JsonFileAnswer>();
    public List<JsonFileAnswer> CorrectAnswer { get; set; } = new List<JsonFileAnswer>();
}
