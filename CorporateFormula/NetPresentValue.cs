using System;
using System.Collections;

namespace CorporateFormula
{
    public class NetPresentValue
    {
        public decimal InitialInvestment { get; set; }
        public decimal DiscountRate { get; set; }

        public decimal CalculateNetPresentValue(ICollection cashFlows)
        {
            decimal sumTotal = 0;
            int count = 1;

            foreach (decimal cashFlow in cashFlows)
            {
                sumTotal += cashFlow / (decimal)Math.Pow((double)(1 + DiscountRate), count);
                count++;
            }
            return -InitialInvestment + sumTotal;
        }
    }
}
