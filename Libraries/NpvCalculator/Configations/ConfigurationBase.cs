using System;

using Microsoft.Extensions.Configuration;

namespace NpvCalculator.Configurations
{
    public abstract class ConfigurationBase
    {
        protected IConfigurationRoot GetConfiguration()
        {
            string applicationSettingJsonFile = "appsettings.json";

            if (NpvCalculatorEnvironment.IsDevelopment)
            {
                applicationSettingJsonFile = "appsettings.Development.json";
            }

            return new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile(applicationSettingJsonFile)
                .Build();
        }

        protected void RaiseValueNotFoundException(string configurationKey)
        {
            throw new Exception($"appsettings key ({configurationKey}) could not be found.");
        }
    }
}
