namespace StockBonds
{
    public class EstimatedEarningsWithProfitMargin
    {
        public decimal ProjectedSales { get; set; }
        public decimal ProjectedNetProfitMargin { get; set; }

        public decimal CalculateEstimatedEarningsWithProfitMargin()
        {
            return ProjectedSales * ProjectedNetProfitMargin;
        }
    }
}
