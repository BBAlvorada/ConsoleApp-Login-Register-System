using System.Linq.Expressions;
using ConsoleApp.Exceptions;
using ConsoleApp.Services;

namespace ConsoleApp.Utils;

public static class ResponseValidateUI
{
    public static void IsMenuInputValid(IObjectCreatingManager objectCreatingManager,
                                        IFileManagement fileManagement,
                                        short response)
    {
        switch (response)
        {
            case 1:
                objectCreatingManager.CreatingObjects(fileManagement);
                break;

            case 2:
                ConsoleUI.GetFileObject(fileManagement);
                break;

            case 3:
                ConsoleUI.UpdateFileObject(fileManagement, objectCreatingManager);
                break;

            case 4:
                ConsoleUI.DeleteFileObject(fileManagement);
                break;

            case 5:
                Environment.Exit(0);
                break;

            default:
                throw new InvalidInputException($"Input - {response}, Invalid.");
        }
    }

    public static bool IsEmailAndPasswordValid(string email, string password) =>
        HasEmailValid(email) && HasPasswordValid(password);

    public static bool IsAgeAndDateValid(string date) =>
        HasDateValid(date);

    public static bool IsAdmissionDateOrTerminatedDateValid(string date, string terminatedDate) =>
        HasDateValid(date) || HasTerminatedDateValid(terminatedDate);

    private static bool HasEmailValid(string email)
    {
        if (email.Contains('@'))
            return true;

        throw new InvalidEmailException($"Email - {email}, Invalid. Should @");
    }

    private static bool HasPasswordValid(string password)
    {
        if (password.Length >= 5)
            return true;

        throw new InvalidPasswordException($"Password - {password}, Invalid. Should length >= 5");
    }

    private static bool HasDateValid(string date)
    {
        var inputDateYear = DateTime.Parse(date).Year;
        var nowDateYear = DateTime.Now.Year;

        if (inputDateYear >= 1980 && inputDateYear <= nowDateYear)
            return true;

        throw new DisallowedDateException($"Date - {date}, Invalid. Should > 1980");
    }

    private static bool HasTerminatedDateValid(string date)
    {
        if (HasDateValid(date))
            return true;

        throw new DisallowedDateException(date);
    }
}