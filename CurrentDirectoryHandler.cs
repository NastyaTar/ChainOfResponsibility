namespace ConsoleApp1;

public class CurrentDirectoryHandler: Handler
{
    protected override bool TryHandle(string[] command)
    {
        if (command[0] != "1")
        {
            return false;
        }
        Console.WriteLine("Current Directory");
        return true;
    }
}