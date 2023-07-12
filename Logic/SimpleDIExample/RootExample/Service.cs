namespace Logic.SimpleDIExample.RootExample;

internal class Service
{
    private readonly DIPHandler _handler;
    private readonly ResultSender _resultSender;

    public Service(DIPHandler handler, ResultSender resultSender)
    {
        _handler = handler ?? throw new ArgumentNullException(nameof(handler));
        _resultSender = resultSender ?? throw new ArgumentNullException(nameof(resultSender));
    }
}
