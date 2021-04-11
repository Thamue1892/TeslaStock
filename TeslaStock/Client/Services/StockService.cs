using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TeslaStock.Shared.Models;

namespace TeslaStock.Client.Services
{
    public class StockService : IStockService
    {
        private readonly HttpClient _httpClient;

        public StockService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<StockData> GetStockData()
        {
            return await _httpClient.GetFromJsonAsync<StockData>(
                "eod?access_key=95a4e1cc4475070e302af03c727c704d&symbols=TSLA");
        }
    }
}
