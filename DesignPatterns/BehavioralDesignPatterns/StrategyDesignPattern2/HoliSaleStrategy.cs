using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern2
{
    public class HoliSaleStrategy : IFestiveSaleStrategy
    {
        public double ApplyDiscount(int amount)
        {
            var discount = (amount - (amount * 0.3));
            Console.WriteLine("Holi Sale Discount (30%) is applied of Rs. " + discount);
            return discount;
        }
    }
}
