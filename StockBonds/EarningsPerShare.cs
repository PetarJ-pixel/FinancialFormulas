namespace StockBonds
{
    public class EarningsPerShare
    {
        public decimal NetIncome { get; set; }
        public decimal WeightedAverageOutstandingShares { get; set; }

        public decimal CalculateEarningsPerShare()
        {
            return NetIncome / WeightedAverageOutstandingShares;
        }
    }
}
