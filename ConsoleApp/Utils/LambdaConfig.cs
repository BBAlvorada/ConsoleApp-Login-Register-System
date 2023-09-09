using ConsoleApp.Models;

namespace ConsoleApp.Utils;

public class LambdaConfig
{
    public static Action<Corporation> AddCorporationsInUserProfile(UserProfile userProfile)
    {
        return (corporation) =>
        {
            userProfile.Corporations!.Add(corporation);
            corporation.UserProfile = userProfile;
        };
    }
}