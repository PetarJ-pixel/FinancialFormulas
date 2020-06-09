namespace Financial
{
    public class AssetTurnover
    {
        public decimal NetSales { get; set; }
        public decimal TotalAssets { get; set; }

        public decimal CalculateAssetTurnover()
        {
            return NetSales / TotalAssets;
        }
    }
}
