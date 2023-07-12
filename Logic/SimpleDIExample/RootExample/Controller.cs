namespace Logic.SimpleDIExample.RootExample;

internal class Controller
{
    private readonly Service _service;

    public Controller(Service service)
    {
        _service = service ?? throw new ArgumentNullException(nameof(service));
    }

    public string Index() => null;
}
