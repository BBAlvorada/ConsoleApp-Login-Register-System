namespace ConsoleApp.Utils;

public class PrinterConsoleUI
{
    public static void MessageConsole(string message) => 
        Console.WriteLine($"{message}");
    
    public static void MessageConsoleException(Exception exception){
        Console.Clear();

        Console.WriteLine(exception.Message);
        Console.WriteLine();
    }

    public static string MessageConsoleException(string message){
        Console.Clear();

        return $"{message}\n";
    }
}