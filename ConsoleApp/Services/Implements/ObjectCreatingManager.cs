using ConsoleApp.Models;
using ConsoleApp.Utils;

namespace ConsoleApp.Services.Implements;

public class ObjectCreatingManager : IObjectCreatingManager<Account>
{
    private readonly IObjectRelationships _objectRelationships;

    public ObjectCreatingManager(IObjectRelationships objectRelationships) =>
        _objectRelationships = objectRelationships;

    public void CreatingObjects(IFileManagement<Account> fileManagement)
    {
        var account = ConsoleUI.CreateAccount();
        var userProfile = ConsoleUI.CreateUserProfile();
        var corporations = ConsoleUI.CreateCorporations();

        _objectRelationships.CreatingRelationships(account, userProfile, corporations);
        
        fileManagement.CreateFile(account);
    }
}