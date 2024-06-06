using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_2
{
    public abstract class BaseLogHandler : ILogHandler
    {
        private ILogHandler _nextHandler;

        public void SetNextHandler(ILogHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public virtual void HandleLog(string message, LogLevel level)
        {
            // Sprawdź, czy ten handler obsługuje podany poziom logowania
            if (CanHandle(level))
            {
                ProcessLog(message);
            }
            else
            {
                // Jeśli nie możemy obsłużyć tego poziomu logowania, przekazujemy go dalej
                _nextHandler?.HandleLog(message, level);
            }
        }

        protected abstract bool CanHandle(LogLevel level);

        protected abstract void ProcessLog(string message);
    }
}
