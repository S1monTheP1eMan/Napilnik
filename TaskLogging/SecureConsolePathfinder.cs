using System;

namespace TaskLogging
{
    class SecureConsolePathfinder : ILogger
    {
        public void Find(string message)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
                Console.WriteLine(message);
        }
    }
}
