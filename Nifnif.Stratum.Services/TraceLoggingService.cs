using Nifnif.Stratum.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Nifnif.Stratum.Services
{
    public class TraceLoggingService : ILoggingService
    {
        public void LogError(string message)
        {
            Trace.TraceError(message);
        }

        public void LogInfo(string message)
        {
            Trace.TraceInformation(message);
        }

        public void LogWarning(string message)
        {
            Trace.TraceWarning(message);
        }
    }
}
