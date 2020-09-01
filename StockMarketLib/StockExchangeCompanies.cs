namespace StockMarketLib
{
   
    public class StockExchangeCompanies
    {
        public int Id { get; set; }
        public string StockExchangeCode { get; set; }
        public virtual StockExchange StockExchange { get; set; }

        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}