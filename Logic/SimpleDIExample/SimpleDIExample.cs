namespace Logic.SimpleDIExample;

public static class SimpleDIExample
{
    public static void RunExample()
    {
        WithoutDIP();
        WithDIP();
    }

    private static void WithoutDIP()
    {
        var handler1 = new Handler(
            new Repository());

        handler1.Handle();

        // Error
        //var handler2 = new Handler(
        //    new DIPRepository());
    }

    private static void WithDIP()
    {
        IRepository dipRepo = new DIPRepository();
        IRepository customRepo = new CustomRepository();

        var handler1 = new DIPHandler(
            dipRepo);
        handler1.Handle();

        var handler2 = new DIPHandler(
            customRepo);
        handler2.Handle();
    }
}
