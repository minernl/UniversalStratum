using System;
using System.Collections.Generic;
using System.Text;

namespace Nifnif.Stratum.Common.Interfaces
{
    public interface ILoggingService
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
    }
}
