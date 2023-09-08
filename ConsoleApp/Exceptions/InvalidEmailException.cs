namespace ConsoleApp.Exceptions;

public class InvalidEmailException : Exception
{
    public InvalidEmailException(string email) :
        base($"\nEmail - {email}, Invalid. Should @\n") { }
}