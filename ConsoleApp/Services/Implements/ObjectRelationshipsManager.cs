using ConsoleApp.Models;

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

    public void UserProfileByCorporation(UserProfile userProfile, Corporation corporation)
    {
        userProfile.Corporation = corporation;
        corporation.UserProfile = userProfile;
    }

    public void CorporationByUserProfile(UserProfile userProfile, Corporation corporation)
    {
        corporation.UserProfile = userProfile;
        userProfile.Corporation = corporation;
    }
}