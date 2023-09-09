using ConsoleApp.Models;

namespace ConsoleApp.Services;

public interface IObjectRelationships
{
    void CreatingRelationships(Account account,
                               UserProfile userProfile,
                               HashSet<Corporation> corporations);
}