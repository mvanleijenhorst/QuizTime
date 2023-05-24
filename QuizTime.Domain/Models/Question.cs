using QuizTime.Domain.Common;
using QuizTime.Domain.Models;

namespace QuizTime.Domain;

public class Question
{
    public Guid Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public List<Answer> Answers { get; set; } = new List<Answer>();
    public List<Answer> CorrectAnswer { get; set; } = new List<Answer>();

    public ValidateResult IsValid()
    {
        return new ValidateResult();
    }
}