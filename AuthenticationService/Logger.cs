using System;
using System.IO;
using System.Threading.Tasks;

namespace AuthenticationService
{
    public class Logger: ILogger
    {
        private async Task AppendLogToFile(string message,string fileName)
        {
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Logs"))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Logs");

            string logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Logs", fileName);

            await File.AppendAllTextAsync(logFilePath, message + Environment.NewLine);
        }
        public async Task WriteEvent(string eventMessage)
        {
            await AppendLogToFile(eventMessage, "events.txt");
            Console.WriteLine(eventMessage);
        }

        public async Task WriteError(string errorMessage)
        {
            await AppendLogToFile(errorMessage, "errors.txt");
            Console.WriteLine(errorMessage);
        }
    }
}
