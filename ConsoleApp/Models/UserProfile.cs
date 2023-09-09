using System.Text;
using ConsoleApp.Utils;

namespace ConsoleApp.Models;

public class UserProfile
{
    public string? FullName { get; set; }
    public int Age { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Corporation? Corporation { get; set; }
    public Account? Account { get; set; }

    public UserProfile(string fullName, string dateOfBirth)
    {
        FullName = fullName;
        Age = UserAgeCalculator.BirthdayAgeCalculator(dateOfBirth);
        DateOfBirth = DateTime.Parse(dateOfBirth);
    }

    public override string ToString()
    {
        return new StringBuilder()
            .Append("User Profile ")
            .Append("{ ")
            .Append($"Full Name: {FullName}, ")
            .Append($"Age: {Age}, ")
            .Append($"Date Of Birth: {DateOfBirth.Date}")
            .AppendLine(" }")
            .Append($"{Corporation}")
            .ToString();
    }
}