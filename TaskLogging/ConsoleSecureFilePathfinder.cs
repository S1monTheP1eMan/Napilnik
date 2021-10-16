using System;
using System.IO;

namespace TaskLogging
{
    class ConsoleSecureFilePathfinder : ILogger
    {
        public void Find(string message)
        {
            Console.WriteLine(message);

            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
                File.WriteAllText("log.txt", message);
        }
    }
}
