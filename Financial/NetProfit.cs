namespace Financial
{
    public class NetProfit
    {
        public decimal GrossProfit { get; set; }
        public decimal OperatingExpenses { get; set; }
        public decimal Taxes { get; set; }
        public decimal Interest { get; set; }

        public decimal CalculateNetProfit()
        {
            return GrossProfit - OperatingExpenses - Taxes - Interest;
        }
    }
}
