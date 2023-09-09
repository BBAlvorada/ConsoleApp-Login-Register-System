using ConsoleApp.Utils;

namespace ConsoleApp.Exceptions;

public class InsufficientAgeException : Exception
{
    public InsufficientAgeException(string message) :
        base(PrinterConsoleUI.MessageConsoleException(message)) { }
}