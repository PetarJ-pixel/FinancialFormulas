namespace StockBonds
{
    public class BookValuePerShare
    {
        public decimal TotalCommonStockholdersEquity { get; set; }
        public decimal NumberOfCommonShares { get; set; }

        public decimal CalculateBookValuePerShare()
        {
            return TotalCommonStockholdersEquity / NumberOfCommonShares;
        }
    }
}
