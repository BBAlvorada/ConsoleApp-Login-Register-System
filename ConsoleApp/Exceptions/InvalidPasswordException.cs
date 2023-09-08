namespace ConsoleApp.Exceptions;

public class InvalidPasswordException : Exception
{
    public InvalidPasswordException(string password) :
        base($"\nPassword - {password}, Invalid. Should length >= 5\n") { }
}