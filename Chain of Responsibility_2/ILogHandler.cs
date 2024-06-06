using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_2
{
    public interface ILogHandler
    {
        void HandleLog(string message, LogLevel level);
    }
}
