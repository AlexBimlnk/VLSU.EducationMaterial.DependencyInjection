using Logic.ContainerExample;
using Logic.TypicalProblems.Factory;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IProcessor _processor;
    private readonly ISenderFactory _senderFactory;

    public WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        IProcessor processor,
        ISenderFactory senderFactory)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _processor = processor ?? throw new ArgumentNullException(nameof(processor));
        _senderFactory = senderFactory ?? throw new ArgumentNullException(nameof(senderFactory));
    }

    [HttpGet]
    public async Task<IEnumerable<WeatherForecast>> GetAsync()
    {
        var sender = _senderFactory.Create(new InputData("aa@aa.com"));

        await _processor.ProcessAsync(CancellationToken.None);

        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
