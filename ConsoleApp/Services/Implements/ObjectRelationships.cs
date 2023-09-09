using ConsoleApp.Models;

namespace ConsoleApp.Services.Implements;

public class ObjectRelationships : IObjectRelationships
{
    private readonly IObjectRelationshipsManager _objectRelationshipsManager;

    public ObjectRelationships(IObjectRelationshipsManager objectRelationshipsManager) => 
        _objectRelationshipsManager = objectRelationshipsManager;

    public void CreatingRelationships(Account account,
                                      UserProfile userProfile,
                                      HashSet<Corporation> corporations)
    {
        _objectRelationshipsManager.AccountByUserProfile(account, userProfile);
        _objectRelationshipsManager.UserProfileByAccount(account, userProfile);

        _objectRelationshipsManager.CorporationsByUserProfile(userProfile, corporations);
        _objectRelationshipsManager.UserProfileByCorporations(userProfile, corporations);
    }
}