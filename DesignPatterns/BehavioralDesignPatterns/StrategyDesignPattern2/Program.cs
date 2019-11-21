using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            var shopper = new Shopper();

            shopper.AddToCart(new Models.Product("001",250));
            shopper.AddToCart(new Models.Product("002", 885));

            Console.WriteLine("Strategy is set to Diwali Sale.");
            
            shopper.SetStrategy(new DiwaliSaleStrategy());
            // or via Property 
            //shopper.Strategy = new DiwaliSaleStrategy();

            shopper.ApplyFestiveDiscount();

            shopper.PrintBill();

            Console.WriteLine("===================================================");

            shopper.AddToCart(new Models.Product("003", 4995));
            shopper.AddToCart(new Models.Product("004", 9874));

            Console.WriteLine("Strategy is set to Holi Sale.");
            shopper.SetStrategy(new HoliSaleStrategy());
            shopper.ApplyFestiveDiscount();

            shopper.PrintBill();

            Console.ReadKey();
        }
    }
}
