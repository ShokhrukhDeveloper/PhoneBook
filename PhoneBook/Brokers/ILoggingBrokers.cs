using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Brokers
{
    interface ILoggingBrokers
    {
        void LogInfo();
        void LogInfo(string message); 
        void LogError(string message);
    }
}
