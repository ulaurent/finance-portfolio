namespace finance_service.Models
{
    public class Stock
    {
        public string Ticker { get; set; }
        public int QueryCount { get; set; }

        public int ResultsCount { get; set; }

        public bool Adjusted { get; set; }

        public List<StockData> Results { get; set; }

        public string Status { get; set; }

        public string Request_Id { get; set; }

        public int Count { get; set; }
    }
}
