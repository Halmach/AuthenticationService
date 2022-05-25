using System.Threading.Tasks;

namespace AuthenticationService
{
    public interface ILogger
    {
        public  Task WriteEvent(string eventMessage);
        public Task WriteError(string errorMessage);  
    }
}
