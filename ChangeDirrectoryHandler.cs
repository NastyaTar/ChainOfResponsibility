namespace ConsoleApp1;

public class ChangeDirrectoryHandler: Handler
{
    protected override bool TryHandle(string[] command)
    {
        if (command[0] != "2")
        {
            return false;
        }

        if (command.Length != 2)
        {
            return false;
        }
        Console.WriteLine("Change Directory");
        return true;
    }
}