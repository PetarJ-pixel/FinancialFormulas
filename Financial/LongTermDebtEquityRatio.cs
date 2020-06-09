namespace Financial
{
    public class LongTermDebtEquityRatio
    {
        public decimal LongTermLiabilities { get; set; }
        public decimal Equity { get; set; }

        public decimal CalculateLongTermDebtEquityRatio()
        {
            return LongTermLiabilities / Equity;
        }
    }
}
