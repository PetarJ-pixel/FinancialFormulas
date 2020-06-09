namespace Financial
{
    public class Equity
    {
        public decimal Assets { get; set; }
        public decimal Liabilities { get; set; }

        public decimal CalculateEquity()
        {
            return Assets - Liabilities;
        }
    }
}
