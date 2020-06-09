namespace Financial
{
    public class Liabilities
    {
        public decimal Assets { get; set; }
        public decimal Equity { get; set; }

        public decimal CalculateLiabilities()
        {
            return Assets - Equity;
        }
    }
}
