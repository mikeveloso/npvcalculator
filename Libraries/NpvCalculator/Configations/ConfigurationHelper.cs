using System;

using Microsoft.Extensions.Configuration;

namespace NpvCalculator.Configurations
{
    public class ConfigurationHelper : ConfigurationBase
    {
        private static string AppSettingFile
        {
            get
            {
                string applicationSettingJsonFile = "appsettings.json";

                if (NpvCalculatorEnvironment.IsDevelopment)
                {
                    applicationSettingJsonFile = "appsettings.Development.json";
                }

                return applicationSettingJsonFile;
            }
        }

        private static IConfigurationRoot AppSettings
        {
            get
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile(AppSettingFile)
                .Build();

                return configuration;
            }
        }

        public static string GetConfiguration(string sectionkey, string key)
        {
            string sectionKey = string.Format("{0}:{1}", sectionkey, key);

            string sectionValue = string.Empty;

            var section = AppSettings.GetSection(sectionKey);

            if (section != null)
            {
                sectionValue = section.Value;
            }

            return sectionValue;
        }
    }
}
