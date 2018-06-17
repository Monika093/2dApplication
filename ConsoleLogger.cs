using System;

namespace _2dWorldApp
{
    public class ConsoleLogger : ILogger
    {
        public void DisplayLog()
        {

        }
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
