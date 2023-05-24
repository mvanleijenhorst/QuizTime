namespace QuizTime.Infra.JsonFile;

public class JsonFileQuiz
{
    public JsonFileQuiz()
    {
        Name = string.Empty;
        Questions = new List<JsonFileQuestion>();
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<JsonFileQuestion> Questions { get; set; }
}
