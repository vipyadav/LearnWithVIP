using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            Product item1 = new Product("1234", 10);
            Product item2 = new Product("5678", 40);

            cart.AddItem(item1);
            cart.AddItem(item2);

            //pay by paypal
            cart.Pay(new PaypalStrategy("er.vipinyadav@gmail.com", "mypwd"));

            //pay by credit card
            cart.Pay(new CreditCardStrategy("Vipin Kumar", "1234567890123456", "786", "12/15"));

            Console.ReadKey();
        }
    }
}
