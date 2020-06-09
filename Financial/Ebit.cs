namespace Financial
{
    public class Ebit
    {
        public decimal Revenue { get; set; }
        public decimal OperatingExpenses { get; set; }

        public decimal CalculateEbit()
        {
            return Revenue - OperatingExpenses;
        }
    }
}
