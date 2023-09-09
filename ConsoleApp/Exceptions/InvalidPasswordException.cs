using ConsoleApp.Utils;

namespace ConsoleApp.Exceptions;

public class InvalidPasswordException : Exception
{
    public InvalidPasswordException(string message) :
        base(PrinterConsoleUI.MessageConsoleException(message)) { }
        
}