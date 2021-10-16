using System;

namespace TaskLogging
{
    class ConsolePathfinder : ILogger
    {
        public void Find(string message)
        {
            Console.WriteLine(message);
        }
    }
}
