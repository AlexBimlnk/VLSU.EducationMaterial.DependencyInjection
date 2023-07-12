namespace Logic.TypicalProblems.GenericProblem;

public interface IGenericProcessor<TData>
{
    public void Process(TData data);
}
