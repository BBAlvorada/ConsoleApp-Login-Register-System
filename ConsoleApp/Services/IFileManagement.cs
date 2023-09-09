namespace ConsoleApp.Services;

public interface IFileManagement
{
    void CreateFile(Object model);

    string GetFile();

    void UpdateFile(Object newModel);

    void DeleteFile();
}