using System.Collections.Generic;

namespace QuizTime.Wpf;

public class QuizSession
{
    public static QuizSession GetInstance()
    {
        return _instance;
    }

    private static readonly QuizSession _instance = new();

    private QuizSession()
    {
        Data = new Dictionary<string, object>();

    }

    public Dictionary<string, object> Data { get; }

}
