namespace ConsoleApp.Exceptions;

public class FilePathNotFoundException : Exception
{
    public FilePathNotFoundException(string path) :
        base($"\nPath {path}, Invalid\n") { }
}