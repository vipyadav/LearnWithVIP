using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWithVIP.GangOfFour.Structural.FactoryMethod
{
    public interface IProduct
    {
        string SayHi();
        void SetPrice(double price);
    }
}
