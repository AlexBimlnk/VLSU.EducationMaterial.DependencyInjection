namespace Logic.ContainerExample;

public sealed class Processor : IProcessor, IDisposable
{
    private readonly IRepository _repository;
    private readonly ICalculator _calculator;
    private readonly ISender _sender;

    public Processor(
        IRepository repository,
        ICalculator calculator,
        ISender sender)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _calculator = calculator ?? throw new ArgumentNullException(nameof(calculator));
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
    }

    public void Dispose()
    {
        Console.WriteLine("Processor disposed");
    }

    public async Task ProcessAsync(CancellationToken token)
    {
        token.ThrowIfCancellationRequested();

        var data = await _repository.GetDataAsync();

        var calculatedData = _calculator.Calculate(data);

        await _sender.SendAsync(calculatedData);
    }
}
