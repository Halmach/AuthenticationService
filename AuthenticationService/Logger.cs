using System;
using System.IO;
using System.Threading.Tasks;

namespace AuthenticationService
{
    public class Logger: ILogger
    {
        
        public async Task WriteEvent(string eventMessage)
        {  
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Logs"))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Logs");

            string logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Logs", "events.txt");

            await File.AppendAllTextAsync(logFilePath, eventMessage + Environment.NewLine);
            Console.WriteLine(eventMessage);
        }

        public async Task WriteError(string errorMessage)
        {
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Logs"))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Logs");

            string errorFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Logs", "errors.txt");

            await File.AppendAllTextAsync(errorFilePath, errorMessage + Environment.NewLine);
            Console.WriteLine(errorMessage);
        }
    }
}
