namespace Logic.ContainerExample;

public interface ISender
{
    public Task SendAsync(int calculatedData);
}
