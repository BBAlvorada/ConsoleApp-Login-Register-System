using ConsoleApp.Exceptions;
using ConsoleApp.Models;

namespace ConsoleApp.Utils;

public static class ConsoleUI
{
    public static void Menu()
    {
        Console.WriteLine("========== Menu ==========");
        Console.WriteLine("1 -> Create Register");

        Console.WriteLine("2 -> Read Register");
        Console.WriteLine("3 -> Update Register");

        Console.WriteLine("4 -> Delete Register");
        // var response = Convert.ToInt16(Console.ReadLine());
    }

    public static Account CreateAccount()
    {
        while (true)
        {
            try
            {
                Console.Write("Email: ");
                var email = Console.ReadLine()!;

                Console.Write("Password: ");
                var password = Console.ReadLine()!;

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
                Console.Write("\nFull Name: ");
                var fullName = Console.ReadLine()!;

                Console.Write("Age: ");
                var age = Convert.ToInt16(Console.ReadLine());

                Console.Write("Date Of Birth: ");
                var dateOfBirth = Console.ReadLine()!;

                if (ResponseValidateUI.IsAgeAndDateValid(age, dateOfBirth.ToString()))
                    return new(fullName, age, dateOfBirth);
            }
            catch (DisallowedDateException ex) { Console.WriteLine(ex.Message); }
            catch (InsufficientAgeException ex) { Console.WriteLine(ex.Message); }
            catch (FormatException ex) { Console.WriteLine(ex.Message); }
        }
    }

    public static Corporation CreateCorporation()
    {
        while (true)
        {
            try
            {
                Console.Write("\nName: ");
                var name = Console.ReadLine()!;

                Console.Write("Admission Date: ");
                var admissionDate = Console.ReadLine()!;

                Console.Write("Terminated Date: ");
                var terminatedDate = Console.ReadLine()!;

                if (ResponseValidateUI.IsAdmissionDateOrTerminatedDateValid(admissionDate,
                                                                            terminatedDate))
                    return new(name, admissionDate, terminatedDate);
            }
            catch (DisallowedDateException ex) { Console.WriteLine(ex.Message); }
            catch (FormatException ex) { Console.WriteLine(ex.Message); }
        }
    }
}