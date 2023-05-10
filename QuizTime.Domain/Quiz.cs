namespace QuizTime.Domain;

public class Quiz
{
    public Quiz()
    {
        Name = string.Empty;
        Vragen = new List<Vraag>();
    }

    public string Name { get; set; }

    public List<Vraag> Vragen { get; set; }

    public bool HeeftVoldoendeVragen()
    {
        return Vragen.Count > 5;
    }
}
