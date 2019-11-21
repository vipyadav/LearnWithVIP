using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern2
{
    public class DiwaliSaleStrategy : IFestiveSaleStrategy
    {
        public double ApplyDiscount(int amount)
        {
            var discount = (amount - (amount * 0.3));
            Console.WriteLine("Diwali Sale Discount(40%) is applied of Rs. " + discount);
            return discount;
        }
    }
}
