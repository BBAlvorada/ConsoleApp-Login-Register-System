using ConsoleApp.Models;

namespace ConsoleApp.Services.Implements;

public class ObjectRelationships : IObjectRelationships
{
    private readonly IObjectRelationshipsManager _objectRelationshipsManager;

    public ObjectRelationships(IObjectRelationshipsManager objectRelationshipsManager) => 
        _objectRelationshipsManager = objectRelationshipsManager;

    public void CreatingRelationships(Account account,
                                      UserProfile userProfile,
                                      Corporation corporation)
    {
        _objectRelationshipsManager.AccountByUserProfile(account, userProfile);
        _objectRelationshipsManager.UserProfileByAccount(account, userProfile);

        _objectRelationshipsManager.CorporationByUserProfile(userProfile, corporation);
        _objectRelationshipsManager.UserProfileByCorporation(userProfile, corporation);
    }
}