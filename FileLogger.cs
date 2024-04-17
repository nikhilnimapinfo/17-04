
using System.IO;


namespace Interface_WIth_Extensiblity
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }
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
            using (var streamwriter = new StreamWriter(_path, true))
            {
                streamwriter.WriteLine(messageType+" : " + message);

            }
        }
    }
}
