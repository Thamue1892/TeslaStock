namespace TeslaStock.Shared.Models
{
    public class StockData
    {
        public Pagination pagination { get; set; }
        public Datum[] data { get; set; }
    }

}
