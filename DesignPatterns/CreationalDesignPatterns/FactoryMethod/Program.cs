using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWithVIP.GangOfFour.Structural.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            //ProductFactory[] productFactory = new ProductFactory[2];

            //productFactory[0] = new MobileConcreteCreatorOrFactory();
            //productFactory[1] = new TabletConcreteCreatorOrFactory();

            ProductFactory factory;

            factory = new MobileConcreteCreatorOrFactory();
            IProduct product = factory.GetInstance();
            
            Console.WriteLine("Created Product = {0}", product.GetType().Name);
            Console.WriteLine(product.SayHi());

            factory = new TabletConcreteCreatorOrFactory();
            product = factory.MakeProduct();

            Console.WriteLine("Created Product = {0}", product.GetType().Name);
            Console.WriteLine(product.SayHi());

            // Wait for user
            Console.ReadKey();
        }
    }
}
