using NpvCalculator.Configurations;

namespace NpvCalculator.Helpers
{
    internal class ApiHelper
    {
        private static string ApiBaseUrl => ConfigurationHelper.GetConfiguration("ApiSettings", "ApiServiceUrl");

        private static string ApiUsername => ConfigurationHelper.GetConfiguration("ApiSettings", "ApiUsername");

        private static string ApiPassword => ConfigurationHelper.GetConfiguration("ApiSettings", "ApiPassword");

        public static string ApiServiceUrl(string serviceName, string actionName)
        {
            return string.Format("{0}/{1}/{2}", ApiBaseUrl, serviceName, actionName);
        }
    }
}
