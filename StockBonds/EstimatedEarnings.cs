namespace StockBonds
{
    public class EstimatedEarnings
    {
        public decimal ForecastedSales { get; set; }
        public decimal ForecastedExpenses { get; set; }

        public decimal CalculateEstimatedEarnings()
        {
            return ForecastedSales - ForecastedExpenses;
        }
    }
}
