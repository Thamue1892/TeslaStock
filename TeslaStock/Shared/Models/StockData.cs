namespace TeslaStock.Shared.Models
{
    public class StockData
    {
        public int Id { get; set; }
        public Pagination pagination { get; set; }
        public Datum[] data { get; set; }
    }

}
