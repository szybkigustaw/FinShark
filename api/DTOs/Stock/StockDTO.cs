using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.DTOs.Stock
{
    public class StockDTO
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = String.Empty;
        public string CompanyName { get; set; } = String.Empty;
        public decimal Price { get; set; }
        public decimal LastDivident { get; set; }
        public string Industry { get; set; } = String.Empty;
        public long MarketCap { get; set; }
    }
}