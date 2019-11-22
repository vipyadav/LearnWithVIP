using System;
using Models;

namespace ChainOfResponsibility2
{
    public class Rupees50Dispenser : ICashDispenser
    {
        private ICashDispenser nextDispenser;

        public void Dispense(Currency cur)
        {
            if (cur.Amount >= 50)
            {
                int num = cur.Amount / 50;
                int remainder = cur.Amount % 50;
                Console.WriteLine ("Dispensing " + num + " Rs. 50 note");
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
