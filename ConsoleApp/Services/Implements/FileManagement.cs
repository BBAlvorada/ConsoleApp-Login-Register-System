namespace ConsoleApp.Services.Implements;

public class FileManagement<T> : IFileManagement<T> where T : class
{
    private readonly string _folderPath;
    private readonly string _filePath;

    public FileManagement()
    {
        _folderPath = @"C:\Users\Virtual Machine\Documents";
        _filePath = Path.Combine(_folderPath, "Login & Register System.txt.");
    }

    public void CreateFile(T model)
    {
        using var writer = new StreamWriter(_filePath, true);

        writer.Write($"{model}");
    }

    public string GetFile()
    {
        using var reader = new StreamReader(_filePath);

        Console.Clear();
        return reader.ReadToEnd();
    }

    public void UpdateFile(T newModel)
    {
        using var writer = new StreamWriter(_filePath);

        writer.WriteLine("Updating:");
        writer.Write(newModel);
    }

    public void DeleteFile() =>
        File.Delete(_filePath);
}