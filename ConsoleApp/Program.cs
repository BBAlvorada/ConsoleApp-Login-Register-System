using ConsoleApp.Services.Implements;
using ConsoleApp.Utils;

namespace ConsoleApp;

public class Program
{
    public static void Main()
    {
        var objectRelationshipsManager = new ObjectRelationshipsManager();
        var objectRelationships = new ObjectRelationships(objectRelationshipsManager);
        var creatingObjects = new ObjectCreatingManager(objectRelationships);

        creatingObjects.CreatingObjects();
    }
}