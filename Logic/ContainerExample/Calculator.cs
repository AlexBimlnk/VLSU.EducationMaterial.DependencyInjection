namespace Logic.ContainerExample;

public sealed class Calculator : ICalculator
{
    public int Calculate(string data)
    {
        Console.WriteLine("Calculate data");
        return 0;
    }
}
