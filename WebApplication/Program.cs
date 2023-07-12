using Logic.ContainerExample;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services
    .AddSingleton<IDataConverter, DataConverter>()
    .AddSingleton<ICalculator, Calculator>()
    .AddSingleton<ISender, Sender>()

    .AddScoped<IRepository, Repository>()
    .AddScoped<IProcessor, Processor>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
