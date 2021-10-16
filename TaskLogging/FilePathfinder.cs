using System.IO;

namespace TaskLogging
{
    class FilePathfinder : ILogger
    {
        public void Find(string message)
        {
            File.WriteAllText("log.txt", message);
        }
    }
}
