namespace StockBonds
{
    public class RequiredRateOfReturn
    {
        public decimal DividentYield { get; set; }
        public decimal GrowthRate { get; set; }

        public decimal CalculateRequiredRateOfReturn()
        {
            return DividentYield + GrowthRate;
        }
    }
}
