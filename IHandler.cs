namespace ConsoleApp1;

public interface IHandler
{
    void Handle(string[] command);
    void AddHandler(IHandler handler);
}