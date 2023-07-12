namespace Logic.TypicalProblems.OneImplAndMoreAbstrations;

public class Converter :
    IConverter<string, int>,
    IConverter<object, string>
{
    public int Convert(string from)
    {
        return 1;
    }

    public string Convert(object from)
    {
        return string.Empty;
    }
}
