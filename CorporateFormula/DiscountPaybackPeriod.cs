using System;

namespace CorporateFormula
{
    public class DiscountPaybackPeriod
    {
        public decimal InitialInvestment { get; set; }
        public decimal Rate { get; set; }
        public decimal PeriodicCashFlow { get; set; }

        public decimal CalculateDiscountedPaybackPeriod()
        {
            return ((decimal)Math.Log(1 / (1 - ((((double)InitialInvestment * (double)Rate) / (double)PeriodicCashFlow)))) / ((decimal)Math.Log((1 + (double)Rate))));
        }
    }
}
