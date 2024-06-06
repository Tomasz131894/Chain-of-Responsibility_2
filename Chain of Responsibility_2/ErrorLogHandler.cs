using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_2
{
    public class ErrorLogHandler : BaseLogHandler
    {
        protected override bool CanHandle(LogLevel level)
        {
            return level == LogLevel.ERROR;
        }

        protected override void ProcessLog(string message)
        {
            Console.WriteLine($"[ERROR] {message}");
        }
    }
}
