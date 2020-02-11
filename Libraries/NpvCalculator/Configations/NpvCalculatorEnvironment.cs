using Microsoft.AspNetCore.Hosting;

namespace NpvCalculator.Configurations
{
    public static class NpvCalculatorEnvironment
    {
        private static IHostingEnvironment HostEnvironment;

        public static void Configure(IHostingEnvironment env)
        {
            HostEnvironment = env;
        }

        public static string Environment => HostEnvironment.EnvironmentName;

        public static bool IsDevelopment => HostEnvironment.IsDevelopment();

        public static string DatabaseConnectionKey => HostEnvironment.IsDevelopment() ? "DevelopmentConnection" : "DefaultConnection";
    }
}
