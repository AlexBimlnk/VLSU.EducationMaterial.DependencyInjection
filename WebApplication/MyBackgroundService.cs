using Logic.TypicalProblems.Background;

namespace WebApplication1;

public class MyBackgroundService : BackgroundService
{
    private readonly IServiceScopeFactory _scopeFactory;

    public MyBackgroundService(IServiceScopeFactory scopeFactory)
    {
        _scopeFactory = scopeFactory;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (true)
        {
            await Task.Delay(2000);

            using var scope = _scopeFactory.CreateScope();

            var handler = scope.ServiceProvider.GetRequiredService<IHandler>();

            handler.Handle();
        }
    }
}
