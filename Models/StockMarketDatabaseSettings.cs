using System;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StockMarket.Models
{
    public class StockMarketDatabaseSettings : IStockMarketDatabaseSettings
    {
        public StockMarketDatabaseSettings()
        {
        }

        public string StocksCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
