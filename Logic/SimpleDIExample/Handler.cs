namespace Logic.SimpleDIExample;

public class Handler
{
    private Repository _repository;

    public Handler(Repository repository)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public void Handle() => _repository.SomeWork();
}
