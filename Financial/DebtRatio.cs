namespace Financial
{
    public class DebtRatio
    {
        public decimal TotalLiabilities { get; set; }
        public decimal TotalAssets { get; set; }

        public decimal CalculateDebtRatio()
        {
            return TotalLiabilities / TotalAssets;
        }
    }
}
