using QuizTime.Wpf;
using System.Collections.Generic;
using System.Windows.Controls;

namespace QuizTime.Wpf;

public class QuizSession
{
    #region Singleton

    /// <summary>
    /// Static variable with the instance of QuizSession
    /// </summary>
    private static readonly QuizSession _instance = new();

    /// <summary>
    /// Static method to get the instance of the QuizSession without initializing the QuizSession object.
    /// </summary>
    /// <returns>QuizSession</returns>
    public static QuizSession GetInstance()
    {
        return _instance;
    }

    #endregion

    /// <summary>
    /// Private constructor, so it cannot be created without this QuizSession.
    /// </summary>
    private QuizSession()
    {
        Data = new Dictionary<string, object>();

    }

    /// <summary>
    /// Property dictionary for data over UserControls.
    /// </summary>
    public Dictionary<string, object> Data { get; }

}
