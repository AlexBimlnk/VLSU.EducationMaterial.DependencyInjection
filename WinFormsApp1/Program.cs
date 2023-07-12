using Logic.ContainerExample;
using Microsoft.Extensions.DependencyInjection;

namespace WinFormsApp1;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var services = new ServiceCollection();

        services
            .AddSingleton<IDataConverter, DataConverter>()
            .AddSingleton<ICalculator, Calculator>()
            .AddSingleton<ISender, Sender>()

            .AddScoped<IRepository, Repository>()
            .AddScoped<IProcessor, Processor>()
            
            .AddScoped<Form1>();

        var serviceProvider = services.BuildServiceProvider(validateScopes: true);

        using var scope = serviceProvider.CreateScope();

        var form = scope.ServiceProvider.GetRequiredService<Form1>();

        Application.Run(form);
    }
}