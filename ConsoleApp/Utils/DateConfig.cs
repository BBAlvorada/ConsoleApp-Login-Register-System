using ConsoleApp.Exceptions;

namespace ConsoleApp.Utils;

public static class DateConfig
{
    private static DateTime _inputDateTime;

    public static int BirthdayAgeCalculator(string dateOfBirth)
    {
        TimeSpan differenceTemp = DateTime.Now - DateTime.Parse(dateOfBirth);

        return (int)differenceTemp.TotalDays / 365;
    }

    public static bool HasDateValid(string terminatedDate, string admissionDate) => 
        IsTerminatedDate(terminatedDate) || IsAdmissionDate(admissionDate);

    public static bool HasDateValid(string admissionDate) => 
        IsAdmissionDate(admissionDate);

    private static bool IsAdmissionDate(string admissionDate)
    {
        if (DateTime.TryParse(admissionDate, out _inputDateTime))
        {
            var inputDateYear = _inputDateTime.Year;
            var currentYear = DateTime.Now.Year;

            if (_inputDateTime.Year >= 1980 && inputDateYear <= currentYear)
                return true;
        }

        throw new DisallowedDateException(
            $"Date - {admissionDate}, Invalid. Should be > 1980 and <= {DateTime.Now.Year}");
    }

    private static bool IsTerminatedDate(string terminatedDate)
    {
        if (DateTime.TryParse(terminatedDate, out _inputDateTime))
        {
            var inputDateYear = _inputDateTime.Year;
            var currentYear = DateTime.Now.Year;

            if (inputDateYear > 1980 && inputDateYear <= currentYear) 
                return true;
        }

        throw new DisallowedDateException(
            $"Date - {terminatedDate}, Invalid. Should be > 1980 and <= {DateTime.Now.Year}");
    }
}