namespace Logic.ContainerExample;

public interface IProcessor
{
    public Task ProcessAsync(CancellationToken token);
}
