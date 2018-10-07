using System;

namespace Nifnif.Stratum.Common
{
    public interface IConfigurationService
    {
        string GetSetting(string key);
    }
}
