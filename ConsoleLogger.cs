using System;

namespace Interface_WIth_Extensiblity
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            
                Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }
}
