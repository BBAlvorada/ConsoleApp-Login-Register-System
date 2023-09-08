namespace ConsoleApp.Exceptions;

public class InsufficientAgeException : Exception
{
    public InsufficientAgeException(short age) :
        base($"\nAge {age}, Invalid. Should > 15") { }
}