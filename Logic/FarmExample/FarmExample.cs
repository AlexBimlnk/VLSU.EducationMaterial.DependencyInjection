namespace Logic.FarmExample;

public static class FarmExample
{
    private static Random _random = new Random();
    private static int _runCount;

    private static readonly Country _country = new Country { Name = "Country Name" };
    

    public static void RunExample()
    {
        CreateScopeNodes();
        Console.WriteLine();
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine();
        CreateScopeNodes();
    }

    private static void CreateScopeNodes()
    {
        using var farmScope = new Farm()
        {
            Name = $"Farm scope {_runCount}"
        };

        var node1 = new WorkerNode(
            _country,
            farmScope,
            new Tractor(farmScope, _random.Next(5, 25)));
        node1.DoWork();

        _runCount++;
    }
}
