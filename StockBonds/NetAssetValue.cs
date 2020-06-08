namespace StockBonds
{
    public class NetAssetValue
    {
        public decimal FundAssets { get; set; }
        public decimal FundLiabilities { get; set; }
        public decimal OutstandingShares { get; set; }

        public decimal CalculateNetAssetValue()
        {
            return (FundAssets - FundLiabilities) / OutstandingShares;
        }
    }
}
