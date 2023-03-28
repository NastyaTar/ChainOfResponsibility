namespace ConsoleApp1;

public class DeleteFileHandler: Handler
{
    protected override bool TryHandle(string[] command)
    {
        if (command[0] != "4")
        {
            return false;
        }
        Console.WriteLine("Delete file");
        return true;
    }
}