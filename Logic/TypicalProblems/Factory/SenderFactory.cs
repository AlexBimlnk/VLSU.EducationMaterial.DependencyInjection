namespace Logic.TypicalProblems.Factory;

public sealed class SenderFactory : ISenderFactory
{
    private readonly Func<InputData, ISender> _factory;

    public SenderFactory(Func<InputData, ISender> factory)
    {
        _factory = factory ?? throw new ArgumentNullException(nameof(factory));
    }

    public ISender Create(InputData inputData)
    {
        ArgumentNullException.ThrowIfNull(inputData);

        return _factory(inputData);
    }
}
