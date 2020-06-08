namespace StockBonds
{
    public class RateOfReturn
    {
        public decimal Dividend { get; set; }
        public decimal Price { get; set; }

        public decimal CalculateRateOfReturn()
        {
            return Dividend / Price;
        }
    }
}
