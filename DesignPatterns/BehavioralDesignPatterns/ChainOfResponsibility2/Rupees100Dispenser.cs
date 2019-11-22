using System;
using Models;

namespace ChainOfResponsibility2
{
    public class Rupees100Dispenser : ICashDispenser
    {
        private ICashDispenser nextDispenser;

        public void Dispense(Currency cur)
        {
            if (cur.Amount >= 100)
            {
                int num = cur.Amount / 100;
                int remainder = cur.Amount % 100;
                Console.WriteLine ("Dispensing " + num + " Rs. 100 note");
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
