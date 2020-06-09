namespace Financial
{
    public class DebtEquityRatio
    {
        public decimal TotalLiabilities { get; set; }
        public decimal ShareholderEquity { get; set; }

        public decimal CalculateDebtEquityRatio()
        {
            return TotalLiabilities / ShareholderEquity;
        }
    }
}
