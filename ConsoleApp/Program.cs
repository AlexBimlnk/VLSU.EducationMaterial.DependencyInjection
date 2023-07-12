using Logic.ContainerExample;
using Microsoft.Extensions.DependencyInjection;

// Simple DI
var services = new ServiceCollection();

services
    .AddSingleton<IDataConverter, DataConverter>()
    .AddSingleton<ICalculator, Calculator>()
    .AddSingleton<ISender, Sender>()

    .AddScoped<IRepository, Repository>()
    .AddScoped<IProcessor, Processor>();

var serviceProvider = services.BuildServiceProvider(validateScopes: true);

using var scope = serviceProvider.CreateScope();

var processor = scope.ServiceProvider.GetRequiredService<IProcessor>();

await processor.ProcessAsync(CancellationToken.None);

