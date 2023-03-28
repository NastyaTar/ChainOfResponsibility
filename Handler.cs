namespace ConsoleApp1;

public abstract class Handler: IHandler
{
    private IHandler? _handler;
    
    public void Handle(string[] command)
    {
        bool isRightCommand = TryHandle(command);

        if (isRightCommand)
        {
            return;
        }
        else if(_handler != null)
        {
            _handler.Handle(command);
        }
    }

    public void AddHandler(IHandler handler)
    {
        if (_handler != null)
        {
            _handler.AddHandler(handler);
        }
        else
        {
            _handler = handler;
        }
    }

    protected abstract bool TryHandle(string[] command);
}