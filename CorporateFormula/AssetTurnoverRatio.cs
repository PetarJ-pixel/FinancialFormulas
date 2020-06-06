namespace CorporateFormula
{
    public class AssetTurnoverRatio
    {
        public decimal SalesRevenue { get; set; }
        public decimal TotalAssets { get; set; }

        public decimal CalculateAssetTurnoverRatio()
        {
            return SalesRevenue / TotalAssets;
        }
    }
}
