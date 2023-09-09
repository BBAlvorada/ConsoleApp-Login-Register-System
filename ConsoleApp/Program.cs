using ConsoleApp.Services.Implements;
using ConsoleApp.Utils;

namespace ConsoleApp;

public class Program
{
    public static void Main()
    {
        var fileManagement = 
            new FileManagement();

        var objectRelationshipsManager = 
            new ObjectRelationshipsManager();

        var objectRelationships = 
            new ObjectRelationships(objectRelationshipsManager);

        var objectCreatingManager = 
            new ObjectCreatingManager(objectRelationships);

        Console.Clear();
        ConsoleUI.Menu(fileManagement, objectCreatingManager);
    }
}