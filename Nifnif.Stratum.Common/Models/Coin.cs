using System;
using System.Collections.Generic;
using System.Text;

namespace Nifnif.Stratum.Common.Models
{
    public class Coin
    {
        public string Name { get; set; } = "Not set";
        public string Symbol { get; set; } = "Not set";
        public Uri Rpc { get; set; }
    }
}
