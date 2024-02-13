namespace finance_service.Models
{
    public class StockData
    {
        /// <summary>
        /// Close
        /// </summary>
        public double C { get; set; }
        /// <summary>
        /// High
        /// </summary>
        public double H { get; set; }
        /// <summary>
        /// Low
        /// </summary>
        public double L { get; set; }
        /// <summary>
        /// Number of transactions
        /// </summary>
        public Int64 N { get; set; }
        /// <summary>
        /// Open
        /// </summary>
        public double O { get; set; }
        /// <summary>
        /// Time stamp
        /// </summary>
        public Int64 T { get; set; }
        /// <summary>
        /// Volume Weighted
        /// </summary>
        public double VW { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        public double V { get; set; }
    }
}