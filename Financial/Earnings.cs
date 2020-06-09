namespace Financial
{
    public class Earnings
    {
        public decimal Revenue { get; set; }
        public decimal OperatingExpenses { get; set; }

        public decimal CalculateEarnings()
        {
            return Revenue - OperatingExpenses;
        }
    }
}
