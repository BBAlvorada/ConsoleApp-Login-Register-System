using ConsoleApp.Models;
using ConsoleApp.Utils;

namespace ConsoleApp.Services.Implements;

public class ObjectRelationshipsManager : IObjectRelationshipsManager
{
    public void AccountByUserProfile(Account account, UserProfile userProfile)
    {
        account.UserProfile = userProfile;
        userProfile.Account = account;
    }

    public void UserProfileByAccount(Account account, UserProfile userProfile)
    {
        userProfile.Account = account;
        account.UserProfile = userProfile;
    }

    public void UserProfileByCorporations(UserProfile userProfile, HashSet<Corporation> corporations)
    {
        var addCorporations = LambdaConfig.AddCorporationsInUserProfile(userProfile);

        foreach (var corporation in corporations)
            addCorporations(corporation);
    }

    public void CorporationsByUserProfile(UserProfile userProfile, HashSet<Corporation> corporations) =>
        UserProfileByCorporations(userProfile, corporations);
}