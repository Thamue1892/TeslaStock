using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using TeslaStock.Client.Services;

namespace TeslaStock.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            var baseUri = builder.HostEnvironment.BaseAddress + "api/";

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddHttpClient<IStockService, StockService>(client =>
                client.BaseAddress = new Uri(baseUri + "stock/"));

            await builder.Build().RunAsync();
        }
    }
}
