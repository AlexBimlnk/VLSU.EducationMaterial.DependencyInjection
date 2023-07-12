namespace Logic.ContainerExample;

public interface IRepository
{
    public Task<string> GetDataAsync();
}
