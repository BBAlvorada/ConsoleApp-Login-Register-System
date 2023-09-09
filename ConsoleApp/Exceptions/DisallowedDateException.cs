using ConsoleApp.Utils;

namespace ConsoleApp.Exceptions;

public class DisallowedDateException : Exception
{
    public DisallowedDateException(string message) :
        base(PrinterConsoleUI.MessageConsoleException(message)) { }
}