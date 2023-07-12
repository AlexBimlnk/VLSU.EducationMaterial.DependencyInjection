namespace Logic.LocatorExample;
internal static class Locator
{
    private static Dictionary<Type, object> _services;

    public static T GetService<T>()
    {
        return (T)_services[typeof(T)];
    }
}
