using System.Collections.Generic;
using System.Threading.Tasks;
using TeslaStock.Shared.Models;

namespace TeslaStock.Client.Services
{
    public interface IStockService
    {
        Task<StockData> GetStockData();
    }
}
