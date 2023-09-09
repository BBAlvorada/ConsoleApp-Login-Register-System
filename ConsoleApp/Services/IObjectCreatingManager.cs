namespace ConsoleApp.Services;

public interface IObjectCreatingManager<T> where T : class
{
    void CreatingObjects(IFileManagement<T> fileManagement);
}