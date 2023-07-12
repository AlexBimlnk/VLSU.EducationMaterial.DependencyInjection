namespace Logic.FarmExample;

public sealed class WorkerNode
{
    private readonly Country _country;
    private readonly Farm _farm;
    private readonly Tractor _tractor;

    public WorkerNode(Country country, Farm farm, Tractor tractor)
    {
        _country = country ?? throw new ArgumentNullException(nameof(country));
        _farm = farm ?? throw new ArgumentNullException(nameof(farm));
        _tractor = tractor ?? throw new ArgumentNullException(nameof(tractor));
    }

    public void DoWork()
    {
        Console.WriteLine($"Country: {_country.Name}");

        Console.WriteLine($"Farm: {_farm.Name}");

        Console.WriteLine($"Tractor energy: {_tractor.Energy}");

        while (_tractor.Energy > 0)
        {
            _tractor.Energy -= 1;

            if (_tractor.Energy % 5 == 0)
            {
                Console.WriteLine(
                    $"\tCountry: {_country.Name}\n" +
                    $"\tFarm: {_farm.Name}\n" +
                    $"\tTractor farm: {_farm.Name}\n" +
                    $"\tTractor energy: {_tractor.Energy}\n" +
                    $"\t***********************************");
            }
        }

    }
}
