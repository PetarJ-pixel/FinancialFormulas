namespace Financial
{
    public class SalesRevenue
    {
        public decimal GrossSales { get; set; }
        public decimal SalesOfReturnAndAllowances { get; set; }

        public decimal CalculateSalesRevenue()
        {
            return GrossSales - SalesOfReturnAndAllowances;
        }
    }
}
