using ConsoleApp.Exceptions;

namespace ConsoleApp.Utils;

public static class ResponseValidateUI
{
    public static bool IsEmailAndPasswordValid(string email, string password) =>
        HasEmailValid(email) && HasPasswordValid(password);

    public static bool IsAgeAndDateValid(short age, string date) =>
        HasAgeValid(age) && HasDateValid(date);

    public static bool IsAdmissionDateOrTerminatedDateValid(string date, string terminatedDate) =>
        HasDateValid(date) || HasTerminatedDateValid(terminatedDate);

    private static bool HasEmailValid(string email)
    {
        if (email.Contains('@'))
            return true;

        throw new InvalidEmailException(email);
    }

    private static bool HasPasswordValid(string password)
    {
        if (password.Length > 5)
            return true;

        throw new InvalidPasswordException(password);
    }

    private static bool HasAgeValid(short age)
    {
        if (age > 15)
            return true;

        throw new InsufficientAgeException(age);
    }

    private static bool HasDateValid(string date)
    {
        var inputDateYear = DateTime.Parse(date).Year;
        var nowDateYear = DateTime.Now.Year;

        if (inputDateYear >= 1980 && inputDateYear <= nowDateYear)
            return true;

        throw new DisallowedDateException(date);
    }

    private static bool HasTerminatedDateValid(string date)
    {
        if (HasDateValid(date))
            return true;

        throw new DisallowedDateException(date);
    }
}