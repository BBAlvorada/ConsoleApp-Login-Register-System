using ConsoleApp.Exceptions;

namespace ConsoleApp.Services.Implements;

public class FileManagement : IFileManagement
{
    private readonly string _folderPath;
    private readonly string _filePath;

    public FileManagement()
    {
        _folderPath = @"C:\Users\Virtual Machine\Documents";
        _filePath = Path.Combine(_folderPath, "Login & Register System.txt.");
    }

    public void CreateFile(object model)
    {
        using var writer = new StreamWriter(_filePath, true);

        writer.Write($"{model}\n");
    }

    public string GetFile()
    {
        using var reader = new StreamReader(_filePath);

        Console.Clear();
        return reader.ReadToEnd();
    }

    public void UpdateFile(object newModel)
    {
        using var writer = new StreamWriter(_filePath);

        writer.WriteLine("Updating:");
        writer.Write(newModel);
    }

    public void DeleteFile() =>
        File.Delete(_filePath);
}