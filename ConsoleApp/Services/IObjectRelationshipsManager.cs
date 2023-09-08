using ConsoleApp.Models;

namespace ConsoleApp.Services;

public interface IObjectRelationshipsManager
{
    void AccountByUserProfile(Account account, UserProfile userProfile);

    void UserProfileByAccount(Account account, UserProfile userProfile);

    void UserProfileByCorporation(UserProfile userProfile, Corporation corporation);

    void CorporationByUserProfile(UserProfile userProfile, Corporation corporation);
}