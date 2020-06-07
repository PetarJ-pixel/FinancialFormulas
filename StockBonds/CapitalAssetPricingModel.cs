namespace StockBonds
{
    public class CapitalAssetPricingModel
    {
        public decimal RiskFreeRate { get; set; }
        public decimal Beta { get; set; }
        public decimal ReturnOnTheMarket { get; set; }

        public decimal CalculateCapitalAssetPricingModel()
        {
            return RiskFreeRate + Beta * (ReturnOnTheMarket - RiskFreeRate);
        }
    }
}
