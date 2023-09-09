using ConsoleApp.Utils;

namespace ConsoleApp.Exceptions;

public class InvalidInputException : Exception
{
    public InvalidInputException(string message) :
        base(PrinterConsoleUI.MessageConsoleException(message)) { }
}