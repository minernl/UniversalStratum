using Nifnif.Stratum.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nifnif.Stratum.Common.Interfaces
{
    public interface IPoolManager
    {
        void NotifyStratumOnlineStatus(StratumConfig stratumConfig);
    }
}
