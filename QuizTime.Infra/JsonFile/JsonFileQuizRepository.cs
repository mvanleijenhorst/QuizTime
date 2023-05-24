using QuizTime.Domain;
using System.Text.Json;

namespace QuizTime.Infra.JsonFile;

public class JsonFileQuizRepository : IQuizRepository
{
    public IEnumerable<Quiz> GetAll()
    {
        throw new NotImplementedException();
    }

    public Quiz GetById(Guid id)
    {
        throw new NotImplementedException();
    }


    public void Save(Quiz quiz)
    {
        throw new NotImplementedException();
    }
    public void Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    private List<JsonFileQuiz> ReadFile()
    {
        var file = File.ReadAllText("quizdata.json");
        return JsonSerializer.Deserialize<List<JsonFileQuiz>>(file) ?? new List<JsonFileQuiz>();
    }

    private void WriteFile(List<JsonFileQuiz> quizList)
    {
        var json = JsonSerializer.Serialize(quizList);
        File.WriteAllText("quizdata.json", json);

    }


}
