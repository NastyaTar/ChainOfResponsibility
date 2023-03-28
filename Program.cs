namespace ConsoleApp1;

internal class Program
{
    private static void Main()
    {
        IHandler handler = new CurrentDirectoryHandler();
        handler.AddHandler(new ChangeDirrectoryHandler());
        handler.AddHandler(new GetFilesHandler());
        handler.AddHandler(new DeleteFileHandler());

        var dir = Directory.GetCurrentDirectory(); 
        var dirOper = new DirectoryOperation(new DirectoryInfo(dir));
        while (true)
        {
            Console.WriteLine("Choose operation:\n" +
                              "1. Where am I?\n" +
                              "2. Change Directory\n" +
                              "3. List of files from current directory\n" +
                              "4. Delete file");
            string operation = Console.ReadLine() ?? string.Empty;
            switch (operation)
            {
                case "1":
                    Console.WriteLine(dirOper.GetNowDir());
                    break;
                case "2":
                    Console.WriteLine("Write new directory");
                    var newDir = new DirectoryInfo(Console.ReadLine() ?? string.Empty);
                    dirOper.ChangeDir(newDir);
                    break;
                case "3":
                    List<FileInfo> listoffiles = dirOper.GetListOfFiles();
                    foreach (FileInfo filename in listoffiles)
                    {
                        Console.WriteLine(filename.FullName);
                    }

                    break;
                case "4":
                    Console.WriteLine("Write file name what you want to delete from list:");
                    var file = new FileInfo(Console.ReadLine() ?? string.Empty);
                    if (dirOper.FindFile(file) != null)
                    {
                        dirOper.DelFile(file);
                    }

                    break;
            }
        }
    }
}