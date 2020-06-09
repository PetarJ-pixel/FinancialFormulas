namespace Financial
{
    public class OperatingProfit
    {
        public decimal GrossProfit { get; set; }
        public decimal OperatingExpenses { get; set; }

        public decimal CalculateOperatingProfit()
        {
            return GrossProfit - OperatingExpenses;
        }
    }
}
