namespace ConsoleApp.Utils;

public class UserAgeCalculator
{
    public static int BirthdayAgeCalculator(string dateOfBirth)
    {
        TimeSpan differenceTemp = DateTime.Now - DateTime.Parse(dateOfBirth);

        return (int)differenceTemp.TotalDays / 365;
    }
}