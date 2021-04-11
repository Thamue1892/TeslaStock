using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using TeslaStock.Client.Services;
using TeslaStock.Shared.Models;

namespace TeslaStock.Client.Pages
{
    public class StockBase : ComponentBase
    {
        [Inject]
        public IStockService StockService { get; set; }

        public StockData Stock;

        protected override async Task OnInitializedAsync()
        {

            Stock = await StockService.GetStockData();
        }
    }
}
