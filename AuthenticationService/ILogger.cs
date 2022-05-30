using System.Threading.Tasks;

namespace AuthenticationService
{
    public interface ILogger
    {
        public void WriteEvent(string eventMessage);
        public void WriteError(string errorMessage);  
    }
}
