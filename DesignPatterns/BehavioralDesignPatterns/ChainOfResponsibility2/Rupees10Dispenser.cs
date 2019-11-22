using System;
using Models;

namespace ChainOfResponsibility2
{
    public class Rupees10Dispenser : ICashDispenser
    {
        private ICashDispenser nextDispenser;

        public void Dispense(Currency cur)
        {
            if (cur.Amount >= 10)
            {
                int num = cur.Amount / 10;
                int remainder = cur.Amount % 10;
                Console.WriteLine ("Dispensing " + num + " Rs. 10 note");
                if (remainder != 0) 
                    nextDispenser.Dispense(new Currency(remainder));
            }
            else
            {
                nextDispenser.Dispense(cur);
            }       
        }

        public void SetNextDispenser(ICashDispenser _nextDispenser)
        {
            nextDispenser = _nextDispenser;
        }
    }
}
