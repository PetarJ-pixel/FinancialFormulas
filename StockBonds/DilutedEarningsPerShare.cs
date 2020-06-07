namespace StockBonds
{
    public class DilutedEarningsPerShare
    {
        public decimal NetIncome { get; set; }
        public decimal AverageShares { get; set; }
        public decimal OtherConvertibleInstruments { get; set; }

        public decimal CalculateDilutedEarningsPerShare()
        {
            return NetIncome + (AverageShares / OtherConvertibleInstruments);
        }
    }
}
