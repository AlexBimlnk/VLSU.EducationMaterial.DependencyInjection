namespace Logic.TypicalProblems.Background;

public sealed class Handler : IHandler
{
    private IRepository _repository;

    public Handler(IRepository repository)
    {
        _repository = repository;
    }

    public void Handle()
    {
        
    }
}
