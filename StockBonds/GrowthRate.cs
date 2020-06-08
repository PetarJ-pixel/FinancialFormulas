namespace StockBonds
{
    public class GrowthRate
    {
        public decimal RetentionRate { get; set; }
        public decimal ReturnOnEquity { get; set; }

        public decimal CalculateGrowthRate()
        {
            return RetentionRate * ReturnOnEquity;
        }
    }
}
