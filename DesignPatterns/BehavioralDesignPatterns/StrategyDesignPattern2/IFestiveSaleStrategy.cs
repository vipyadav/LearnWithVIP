using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern2
{
    public interface IFestiveSaleStrategy
    {
        double ApplyDiscount(int amount);
    }
}
