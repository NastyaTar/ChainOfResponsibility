namespace ConsoleApp1;

public class GetFilesHandler: Handler
{
    protected override bool TryHandle(string[] command)
    {
        if (command[0] != "3")
        {
            return false;
        }
        Console.WriteLine("Files from Directory");
        return true;
    }   
}