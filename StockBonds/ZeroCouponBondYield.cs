using System;

namespace StockBonds
{
    public class ZeroCouponBondYield
    {
        public decimal FaceValue { get; set; }
        public decimal PresentValue { get; set; }
        public decimal TimeToMaturity { get; set; }

        public decimal CalculateZeroCouponBondYield()
        {
            return (decimal)Math.Pow((double)(FaceValue / PresentValue), (double)(1 / TimeToMaturity)) - 1;
        }
    }
}
