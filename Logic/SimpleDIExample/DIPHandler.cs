namespace Logic.SimpleDIExample;

public class DIPHandler
{
    private IRepository _repository;

    public DIPHandler(IRepository repository)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public void Handle() => _repository.SomeWork();
}
