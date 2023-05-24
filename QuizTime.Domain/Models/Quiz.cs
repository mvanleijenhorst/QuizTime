namespace QuizTime.Domain;

public class Quiz
{
    public Quiz()
    {
        Id = Guid.NewGuid();
        Name = string.Empty;
        Questions = new List<Question>();
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<Question> Questions { get; set; }

    public int QuestionCount => Questions.Count;


    public bool HeeftVoldoendeVragen()
    {
        return Questions.Count > 5;
    }
}
