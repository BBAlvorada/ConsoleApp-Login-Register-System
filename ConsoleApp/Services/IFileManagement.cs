namespace ConsoleApp.Services;

public interface IFileManagement<T> where T : class
{
    void CreateFile(T model);

    string GetFile();

    void UpdateFile(T newModel);

    void DeleteFile();
}