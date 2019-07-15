using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWithVIP.GangOfFour.Structural.FactoryMethod
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    public abstract class ProductFactory
    {
        public abstract IProduct MakeProduct();

        public IProduct GetInstance() // Implementation of Factory Method.
        {
            return MakeProduct();
        }
    }
}
