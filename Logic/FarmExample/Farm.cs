namespace Logic.FarmExample;

public sealed class Farm : IDisposable
{
    public required string Name { get; init; }

    public void Dispose()
    {
        Console.WriteLine($"Farm {Name} disposed");
    }
}
