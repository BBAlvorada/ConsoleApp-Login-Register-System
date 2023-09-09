using ConsoleApp.Models;

namespace ConsoleApp.Services;

public interface IObjectRelationshipsManager
{
    void AccountByUserProfile(Account account, UserProfile userProfile);

    void UserProfileByAccount(Account account, UserProfile userProfile);

    void UserProfileByCorporations(UserProfile userProfile, HashSet<Corporation> corporations);

    void CorporationsByUserProfile(UserProfile userProfile, HashSet<Corporation> corporations);
}