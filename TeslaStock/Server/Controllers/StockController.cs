using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TeslaStock.Server.Services;
using TeslaStock.Shared.Models;

namespace TeslaStock.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockService _stockService;
        private readonly ILogger<StockController> _logger;

        public StockController(IStockService stockService, ILogger<StockController> logger)
        {
            _stockService = stockService;
            _logger = logger;
        }

        [HttpGet]
        public Task<StockData> GetStock()
        {
            _logger.LogDebug("Getting stock");
            try
            {
                return _stockService.GetStockData();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                throw;
            }

        }

    }
}
