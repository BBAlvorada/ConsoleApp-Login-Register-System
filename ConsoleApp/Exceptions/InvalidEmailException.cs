using ConsoleApp.Utils;

namespace ConsoleApp.Exceptions;

public class InvalidEmailException : Exception
{
    public InvalidEmailException(string message) :
        base(PrinterConsoleUI.MessageConsoleException(message)) { }
}