namespace StockBonds
{
    public class BidAskSpread
    {
        public decimal Bid { get; set; }
        public decimal Ask { get; set; }

        public decimal CalculateBidAskSpread()
        {
            return Ask - Bid;
        }
    }
}
