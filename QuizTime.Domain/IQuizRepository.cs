namespace QuizTime.Domain;

public interface IQuizRepository
{
    Quiz GetById(Guid id);

    void Save(Quiz quiz);

    void Delete(Guid id);

    IEnumerable<Quiz> GetAll();
}