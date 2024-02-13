using finance_service.Models;
using Newtonsoft.Json;

namespace finance_service.Repositories
{
    public class StocksRepository : IStockRepository
    {
        private static string baseUrl = "https://api.polygon.io/";
        private readonly string api_Key = "X19PKbIEAIKrQQW4qn3latXhUWnBfmni";

        public async Task<Stock> GetById(string id)
        {
            // Make call to Polugon.io API (External API)
            string mid = "v2/aggs/ticker/"+id+"/range/1/day/";

            var stockJson = String.Empty;

            try
            {
                stockJson = await GetStringAsync(baseUrl + mid + GetDate() + '/' + GetDate() + "?adjusted=true&sort=asc&limit=120&apiKey=" + api_Key);
            }
            catch (Exception)
            {
                throw;
            }

            var stock = JsonConvert.DeserializeObject<Stock>(stockJson);

            return stock;
        }

        private async static Task<string> GetStringAsync(string url)
        {
            using(var client = new HttpClient())
            {
                var response  = await client.GetStringAsync(url);
                return response;
            }
        }

        private string GetDate()
        {
            // Get today's date
            DateTime today = DateTime.Today;

            // Subtract one day to get yesterday's date
            DateTime yesterday = today.AddDays(-1);

            // Format yesterday's date as YYYY-MM-DD
            string formattedDate = yesterday.ToString("yyyy-MM-dd");

            return formattedDate;
        }
    }
}
