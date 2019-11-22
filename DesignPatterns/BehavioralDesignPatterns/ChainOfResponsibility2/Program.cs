using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICashDispenser c1 = new Rupees100Dispenser();
            ICashDispenser c2 = new Rupees50Dispenser();
            ICashDispenser c3 = new Rupees10Dispenser();

            // set the chain of responsibility
            c1.SetNextDispenser(c2);
            c2.SetNextDispenser(c3);

            Console.WriteLine("Enter amount to dispense: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount % 10 != 0)
            {
                Console.WriteLine("Amount should be in multiple of 10s.");
                return;
            }

            c1.Dispense(new Currency(amount));

        }
    }
}
