using System;

namespace FileLoggerKata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileLogger = new FileLogger(new DateTimeProvider());
            fileLogger.Log("test");











            Console.ReadKey();
        }
    }
}