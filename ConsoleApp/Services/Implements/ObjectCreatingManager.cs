using ConsoleApp.Models;
using ConsoleApp.Utils;

namespace ConsoleApp.Services.Implements;

public class ObjectCreatingManager : IObjectCreatingManager
{
    private readonly IObjectRelationships _objectRelationships;

    public ObjectCreatingManager(IObjectRelationships objectRelationships) =>
        _objectRelationships = objectRelationships;

    public void CreatingObjects(IFileManagement fileManagement)
    {
        var account = ConsoleUI.CreateAccount();
        var userProfile = ConsoleUI.CreateUserProfile();
        var corporation = ConsoleUI.CreateCorporation();

        _objectRelationships.CreatingRelationships(account, userProfile, corporation);

        fileManagement.CreateFile(account);
    }
}