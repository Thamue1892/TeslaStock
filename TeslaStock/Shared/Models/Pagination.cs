﻿namespace TeslaStock.Shared.Models
{
    public class Pagination
    {
        public int Id { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public int count { get; set; }
        public int total { get; set; }
    }
}
