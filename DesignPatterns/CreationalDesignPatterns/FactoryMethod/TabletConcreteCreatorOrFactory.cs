using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWithVIP.GangOfFour.Structural.FactoryMethod
{
    public class TabletConcreteCreatorOrFactory : ProductFactory
    {
        public override IProduct MakeProduct()
        {
            return new Tablet();
        }
    }
}
