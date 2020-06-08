namespace StockBonds
{
    public class StockPresentValueWithConstantGrowth
    {
        public decimal EstimatedDividendsForNextPeriod { get; set; }
        public decimal RequiredRateOfReturn { get; set; }
        public decimal GrowthRate { get; set; }

        public decimal CalculateStockPresentValueWithConstantGrowth()
        {
            return EstimatedDividendsForNextPeriod / (RequiredRateOfReturn - GrowthRate);
        }
    }
}
