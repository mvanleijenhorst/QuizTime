namespace QuizTime.Domain.Common;

public class ValidateResult
{
    private readonly List<string> _messages;

    public ValidateResult()
    {
        _messages = new List<string>();
    }

    public void AddMessage(string message)
    {
        _messages.Add(message);
    }

    public IEnumerable<string> GetMessages()
    {
        return _messages;
    }

    public bool IsValid()
    {
        return !_messages.Any();
    }
}
