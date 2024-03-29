﻿using System.Net.Http;
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
            return await _httpClient.GetFromJsonAsync<StockData>("");
        }
    }
}
