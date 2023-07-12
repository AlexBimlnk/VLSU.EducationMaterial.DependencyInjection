using Logic.TypicalProblems.OneImplAndMoreAbstrations;
using Logic.TypicalProblems.GenericProblem;
using Logic.TypicalProblems.Factory;
using Logic.TypicalProblems.Background;

namespace WebApplication1;

public static class MyRegistration
{
    public static IServiceCollection AddMyServiceExamples(this IServiceCollection services)
    {
        return services
            .AddOneImplAndMoreAbstraction()
            .AddGenericProblem()
            .AddFactory()
            .AddMyBackground();

    }

    private static IServiceCollection AddOneImplAndMoreAbstraction(this IServiceCollection services)
    {
        return services
            // Так вы создадите два компонента
            .AddSingleton<IConverter<string, int>, Converter>()
            .AddSingleton<IConverter<object, string>, Converter>()

            // Так один компонент будет подставляться под разные интерфейсы
            .AddSingleton<Converter>()
            .AddSingleton<IConverter<string, int>>(sp => sp.GetRequiredService<Converter>())
            .AddSingleton<IConverter<object, string>>(sp => sp.GetRequiredService<Converter>());

    }

    private static IServiceCollection AddGenericProblem(this IServiceCollection services)
    {
        return services
            // Можно, но объемно
            .AddSingleton<IGenericProcessor<int>, MyGenericProcessor<int>>()
            .AddSingleton<IGenericProcessor<string>, MyGenericProcessor<string>>()
            .AddSingleton<IGenericProcessor<object>, MyGenericProcessor<object>>()

            // Короче
            .AddSingleton(typeof(IGenericProcessor<>), typeof(MyGenericProcessor<>));

    }

    private static IServiceCollection AddFactory(this IServiceCollection services)
    {
        return services
            .AddSingleton<ISenderFactory, SenderFactory>()
            .AddSingleton<ICache, Cache>()
            .AddSingleton<Func<InputData, ISender>>(
                static provider => (inputData) =>
                    ActivatorUtilities.CreateInstance<EmailSender>(provider, inputData.Data));

    }

    private static IServiceCollection AddMyBackground(this IServiceCollection services)
    {
        return services
            .AddScoped<IHandler, Handler>()
            .AddScoped<IRepository, SomeRepository>()
            
            .AddHostedService<MyBackgroundService>();
    }
}
