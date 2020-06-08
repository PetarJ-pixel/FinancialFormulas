namespace StockBonds
{
    public class RiskPremium
    {
        public decimal AssetOrInvestmentReturn { get; set; }
        public decimal RiskFreeReturn { get; set; }

        public decimal CalculateRiskPremium()
        {
            return AssetOrInvestmentReturn - RiskFreeReturn;
        }
    }
}
