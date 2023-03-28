namespace ConsoleApp1;

public class DirectoryOperation
{
    public DirectoryOperation(DirectoryInfo nowDir = default)
    {
        NowDirr = nowDir;
    }

    public DirectoryInfo NowDirr { get; private set; }

    public DirectoryInfo GetNowDir()
    {
        return NowDirr;
    }

    public void ChangeDir(DirectoryInfo dir)
    {
        NowDirr = dir;
    }

    public List<FileInfo> GetListOfFiles()
    {
        return new List<FileInfo>(NowDirr.GetFiles());
    }

    public void DelFile(FileInfo name)
    {
        name.Delete();
    }

    public FileInfo? FindFile(FileInfo fileName)
    {
        return GetListOfFiles().Find(f => f == fileName);
    }
}
