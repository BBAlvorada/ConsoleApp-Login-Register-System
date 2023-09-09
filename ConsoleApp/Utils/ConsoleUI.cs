using ConsoleApp.Exceptions;
using ConsoleApp.Models;
using ConsoleApp.Services;

namespace ConsoleApp.Utils;

public static class ConsoleUI
{
    public static void Menu(IFileManagement<Account> fileManagement,
                            IObjectCreatingManager<Account> objectCreatingManager)
    {
        while (true)
        {
            try
            {
                Console.WriteLine("========== Menu ==========");
                Console.WriteLine("1 - Create Register");

                Console.WriteLine("2 - Read Register");
                Console.WriteLine("3 - Update Register");

                Console.WriteLine("4 - Delete Register");
                Console.WriteLine("5 - Exit");

                Console.Write("==========================\n-> ");
                var response = Convert.ToInt16(Console.ReadLine());

                Console.Clear();
                ResponseValidateUI.IsMenuInputValid(objectCreatingManager,
                                                    fileManagement,
                                                    response);
            }
            catch (InvalidInputException ex) { PrinterConsoleUI.MessageConsoleException(ex); }
            catch (FormatException ex) { PrinterConsoleUI.MessageConsoleException(ex); }
            catch (FileNotFoundException ex) { PrinterConsoleUI.MessageConsoleException(ex); }
        }
    }

    public static Account CreateAccount()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("============= Account ============");

                Console.Write("Email: ");
                var email = Console.ReadLine()!;

                Console.Write("Password: ");
                var password = Console.ReadLine()!;

                Console.WriteLine("==================================\n");
                if (ResponseValidateUI.IsEmailAndPasswordValid(email, password))
                    return new(email, password!);
            }
            catch (InvalidEmailException ex) { Console.WriteLine(ex.Message); }
            catch (InvalidPasswordException ex) { Console.WriteLine(ex.Message); }
        }
    }

    public static UserProfile CreateUserProfile()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("========== User-Profile ==========");

                Console.Write("Full Name: ");
                var fullName = Console.ReadLine()!;

                Console.Write("Date Of Birth: ");
                var dateOfBirth = Console.ReadLine()!;

                Console.WriteLine("==================================\n");
                if (DateConfig.HasDateValid(dateOfBirth))
                    return new(fullName, dateOfBirth);
            }
            catch (DisallowedDateException ex) { PrinterConsoleUI.MessageConsole(ex.Message); }
            catch (InsufficientAgeException ex) { PrinterConsoleUI.MessageConsole(ex.Message); }
            catch (FormatException ex) { PrinterConsoleUI.MessageConsole(ex.Message); }
        }
    }

    public static Corporation CreateCorporation()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("=========== Corporation ==========");

                Console.Write("Name: ");
                var name = Console.ReadLine()!;

                Console.Write("Admission Date: ");
                var admissionDate = Console.ReadLine()!;

                Console.Write("Terminated Date: ");
                var terminatedDate = Console.ReadLine()!;

                Console.WriteLine("==================================\n");
                if (DateConfig.HasDateValid(admissionDate, terminatedDate))
                    return new(name, admissionDate, terminatedDate);

            }
            catch (DisallowedDateException ex) { Console.WriteLine(ex.Message); }
            catch (FormatException ex) { Console.WriteLine(ex.Message); }
        }
    }

    public static HashSet<Corporation> CreateCorporations()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("=========== Corporations ==========");
                Console.Write("How Many Corporations Want To Add: ");

                var CorporationsInput = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("==================================\n");

                var corporationsList = new HashSet<Corporation>();

                for (int i = 1; i <= CorporationsInput; i++)
                    corporationsList.Add(CreateCorporation());
                
                return corporationsList;
            }
            catch (FormatException ex) { Console.WriteLine(ex.Message); }
        }
    }

    public static void GetFileObject(IFileManagement<Account> fileManagement) =>
        Console.WriteLine(fileManagement.GetFile());

    public static void UpdateFileObject(IFileManagement<Account> fileManagement,
                                        IObjectCreatingManager<Account> objectCreatingManager) =>
        objectCreatingManager.CreatingObjects(fileManagement);

    public static void DeleteFileObject(IFileManagement<Account> fileManagement)
    {
        fileManagement.DeleteFile();
        PrinterConsoleUI.MessageConsole("Deleted Sucessfully\n");
    }
}