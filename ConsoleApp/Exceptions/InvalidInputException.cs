namespace ConsoleApp.Exceptions;

public class InvalidInputException : Exception
{
    public InvalidInputException(short response) :
        base($"Response {response}, Invalid. Try Again!!") { }
}