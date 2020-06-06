namespace CorporateFormula
{
    public class AssetToSalesRatio
    {
        public decimal TotalAssets { get; set; }
        public decimal SalesRevenue { get; set; }

        public decimal CalculateAssetToSalesRatio()
        {
            return TotalAssets / SalesRevenue;
        }
    }
}
