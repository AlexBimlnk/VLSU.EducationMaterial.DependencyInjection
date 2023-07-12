namespace Logic.TypicalProblems.Factory;

public sealed class EmailSender : ISender
{
    private readonly string _email;
    private readonly ICache _cache;

    public EmailSender(string email, ICache cache)
    {
        _email = email;
        _cache = cache ?? throw new ArgumentNullException(nameof(cache));
    }

    public void Send(string message)
    {
        // some work
    }
}
