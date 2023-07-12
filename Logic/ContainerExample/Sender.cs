namespace Logic.ContainerExample;

public sealed class Sender : ISender
{
    public string Email { get; set; }

    public Task SendAsync(int calculatedData)
    {
        Console.WriteLine("Send data async");
        return Task.CompletedTask;
    }
}
