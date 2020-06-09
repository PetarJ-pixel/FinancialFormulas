namespace Financial
{
    public class ReceivablesTurnoverRatio
    {
        public decimal NetCreditSale { get; set; }
        public decimal AverageNetReceivables { get; set; }

        public decimal CalculateReceivablesTurnoverRatio()
        {
            return NetCreditSale / AverageNetReceivables;
        }
    }
}
