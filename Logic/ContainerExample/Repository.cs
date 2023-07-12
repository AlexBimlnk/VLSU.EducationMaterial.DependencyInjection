namespace Logic.ContainerExample;
public sealed class Repository : IRepository, IDisposable
{
    private readonly IDataConverter _converter;

    public Repository(IDataConverter converter)
    {
        _converter = converter ?? throw new ArgumentNullException(nameof(converter));
    }

    public void Dispose()
    {
        Console.WriteLine("Repository disposed");
    }

    public Task<string> GetDataAsync()
    {
        var someData = new object();

        var convertedData = _converter.Convert(someData);

        Console.WriteLine("Get data from repository");

        return Task.FromResult(convertedData);
    }
}
