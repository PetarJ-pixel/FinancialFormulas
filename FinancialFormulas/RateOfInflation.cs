namespace FinancialFormulas
{
    public class RateOfInflation
    {
        public decimal InitialConsumerPriceIndex { get; set; }
        public decimal EndingConsumerPriceIndex { get; set; }

        public decimal CalculateRateOfInflation()
        {
            return (EndingConsumerPriceIndex - InitialConsumerPriceIndex) / InitialConsumerPriceIndex;
        }
    }
}
