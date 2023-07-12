namespace Logic.FarmExample;

public sealed class Tractor
{
    public Tractor(Farm farm, int energy)
    {
        Farm = farm ?? throw new ArgumentNullException(nameof(farm));
        Energy = energy;
    }

    public int Energy { get; set; }

    public Farm Farm { get; }
}
