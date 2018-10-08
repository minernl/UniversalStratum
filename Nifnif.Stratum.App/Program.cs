using Microsoft.Extensions.DependencyInjection;
using Nifnif.Stratum.Common;
using Nifnif.Stratum.Common.Interfaces;
using Nifnif.Stratum.Services;
using System;

namespace Nifnif.Stratum.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddSingleton<IPoolManager, YiimpPoolManager>();
            services.AddSingleton<IConfigurationService, AppConfigConfigurationService>();
            services.AddSingleton<ILoggingService, TraceLoggingService>();
            var provider = services.BuildServiceProvider();

            while (true) {
                // Notify pool that we are still online
                var poolManager = provider.GetService<IPoolManager>();

                // 
            }
        }
    }
}
