namespace Logic.ContainerExample;
public sealed class DataConverter : IDataConverter
{
    public string Convert(object value)
    {
        Console.WriteLine("Convert data");

        return string.Empty;
    }
}
