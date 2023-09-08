namespace ConsoleApp.Services;

public interface IFileManagement
{
    void CreateFile(string path, Object model);

    void GetFile(string path);

    void UpdateFile(string path, Object newModel);

    void DeleteFile(string path);
}