using System.Diagnostics;

namespace Calculator.Models
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Debug.Print(message);
        }
    }
}
