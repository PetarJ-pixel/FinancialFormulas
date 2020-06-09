namespace Financial
{
    public class Assets
    {
        public decimal Liabilities { get; set; }
        public decimal Equity { get; set; }

        public decimal CalculateAssets()
        {
            return Liabilities + Equity;
        }
    }
}
