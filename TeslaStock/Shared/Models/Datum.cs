using System;

namespace TeslaStock.Shared.Models
{
    public class Datum
    {
        public float open { get; set; }
        public float high { get; set; }
        public float low { get; set; }
        public float close { get; set; }
        public float volume { get; set; }
        public float? adj_high { get; set; }
        public float? adj_low { get; set; }
        public float adj_close { get; set; }
        public float? adj_open { get; set; }
        public float? adj_volume { get; set; }
        public float split_factor { get; set; }
        public string symbol { get; set; }
        public string exchange { get; set; }
        public string date { get; set; }
    }
}