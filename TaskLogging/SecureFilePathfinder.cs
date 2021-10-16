using System;
using System.IO;

namespace TaskLogging
{
    class SecureFilePathfinder : ILogger
    {
        public void Find(string message)
        {
            if(DateTime.Now.DayOfWeek == DayOfWeek.Friday)
                File.WriteAllText("log.txt", message);
        }
    }
}
