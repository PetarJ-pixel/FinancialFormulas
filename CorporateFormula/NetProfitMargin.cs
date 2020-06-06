namespace CorporateFormula
{
    public class NetProfitMargin
    {
        public decimal NetIncome { get; set; }
        public decimal SalesRevenue { get; set; }

        public decimal CalculateNetProfitMargin()
        {
            return NetIncome / SalesRevenue;
        }
    }
}
