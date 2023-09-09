using ConsoleApp.Exceptions;
using ConsoleApp.Models;
using ConsoleApp.Services;

namespace ConsoleApp.Utils;

public static class ResponseValidateUI
{
    public static void IsMenuInputValid(IObjectCreatingManager<Account> objectCreatingManager,
                                        IFileManagement<Account> fileManagement,
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
}