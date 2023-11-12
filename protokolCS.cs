using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string logFile = "log.txt";

        try
        {
            int a = 10;
            int b = 0;

            int result = Divide(a, b);
            Console.WriteLine("Результат деления: " + result);
        }
        catch (Exception e)
        {
            LogException(logFile, e);
            Console.WriteLine("Ошибка при выполнении операции.");
        }
    }

    static int Divide(int a, int b)
    {
        try
        {
            return a / b;
        }
        catch (DivideByZeroException e)
        {
            throw new DivideByZeroException("Деление на ноль", e);
        }
    }

    static void LogException(string logFile, Exception e)
    {
        using (StreamWriter writer = File.AppendText(logFile))
        {
            writer.WriteLine("[" + DateTime.Now + "] " + e.GetType() + ": " + e.Message);
            writer.WriteLine("StackTrace: " + e.StackTrace);
            writer.WriteLine();
        }
    }
}