namespace Logic.SimpleDIExample;

public sealed class DIPRepository : IRepository
{
    public void SomeWork()
    {
        Console.WriteLine("DIP Repo work");
    }
}
