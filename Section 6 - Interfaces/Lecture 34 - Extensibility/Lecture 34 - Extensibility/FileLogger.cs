using System.IO;

namespace Lecture_34___Extensibility
{
    // Watch Lecture 34 @ 16:00 minutes for explanation of Extending using an Interface
    // Class FileLogger implements ILogger interface
    public class FileLogger : ILogger
    {
        private readonly string _path;

        // ctor+Tab to create the constructor 
        // Press Alt+Enter to create the private field _path
        // INSIGHT:  when FileLogger(path) is called from main(), path is passed in as an argument
        // then path is assigned to the private field _path and can be used elsewhere in this class
        public FileLogger(string path)
        {
            _path = path;
        }

        // Press Alt+Enter to create this method from ILogger
        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }
}
