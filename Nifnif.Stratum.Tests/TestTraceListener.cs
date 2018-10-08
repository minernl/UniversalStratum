using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Nifnif.Stratum.Tests
{
    public class TestTraceListener : TraceListener
    {
        public string WrittenValue {get;set;}

        public override void Write(string message)
        {
            WrittenValue = message;
        }

        public override void WriteLine(string message)
        {
            WrittenValue = message;
        }
    }
}
