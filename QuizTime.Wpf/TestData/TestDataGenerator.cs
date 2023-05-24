using QuizTime.Domain;
using QuizTime.Infra.JsonFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTime.Wpf.TestData;

public static class TestDataGenerator
{
    public static void Generate()
    {
        var repository = new JsonFileQuizRepository();

        for (int quizIndex = 0; quizIndex < 5; quizIndex++)
        {
            var quiz = new Quiz
            {
                Id = Guid.NewGuid(),
                Name = $"Quiz {quizIndex + 1}",
                Questions = new List<Question>()
            };

            for (int vraagIndex = 0; vraagIndex < 10; vraagIndex++)
            {
                var vraag = new Question
                {
                    Id = Guid.NewGuid(),
                    Text = $"Quiz {quizIndex + 1} - Vraag {vraagIndex + 1}",
                    //Answers = new List<string>(),
                    //CorrectAnswer = "Antwoord 1"
                };

                for (int antwoordIndex = 0; antwoordIndex < 4; antwoordIndex++)
                {
                    //vraag.Answers.Add($"Antwoord {antwoordIndex + 1}");
                }

                quiz.Questions.Add(vraag);
            }

            repository.Save(quiz);
        }
    }
}
