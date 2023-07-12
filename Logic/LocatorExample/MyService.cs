namespace Logic.LocatorExample;
internal class MyService
{
    private readonly IRepository _repository;

    public MyService()
    {
        _repository = Locator.GetService<IRepository>();
    }

    public void SomeWork()
    {
        var sender = Locator.GetService<ISender>();
        // ....
    }
}
