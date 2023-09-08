namespace ConsoleApp.Exceptions;

public class DisallowedDateException : Exception
{
    public DisallowedDateException(string date) :
        base($"\nDate {date}, Invalid. Should > 1980\n") { }
}