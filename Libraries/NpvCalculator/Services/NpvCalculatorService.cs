using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using NpvCalculator.Helpers;
using NpvCalculator.Models;

namespace NpvCalculator.Services
{
    public class NpvCalculatorService : INpvCalculatorService
    {
        private readonly HttpClient client;

        public NpvCalculatorService(HttpClient httpClient) => client = httpClient;

        public Npv CalculateNpv(Npv npv)
        {
            try
            {
                var npvContent = new StringContent(JsonConvert.SerializeObject(npv), Encoding.UTF8, "application/json");
                var response = Task.Run(async () => await client.PostAsync(ApiHelper.ApiServiceUrl("npv", "calculate"), npvContent)).Result;
                
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = Task.Run(async () => await response.Content.ReadAsStringAsync()).Result;

                    if (!string.IsNullOrEmpty(responseContent))
                    {
                        npv = JsonConvert.DeserializeObject<Npv>(responseContent);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }

            return npv;
        }
    }
}
