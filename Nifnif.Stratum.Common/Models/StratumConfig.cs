using System;
using System.Collections.Generic;
using System.Text;

namespace Nifnif.Stratum.Common.Models
{
    public class StratumConfig
    {
        public string Algo { get; set; }
        public string PID { get; set; }
        public Uri StratumUri { get; set; }
    }
}
