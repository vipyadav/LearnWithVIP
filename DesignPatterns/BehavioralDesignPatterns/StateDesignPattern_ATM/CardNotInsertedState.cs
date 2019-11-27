using System;

namespace StateDesignPattern_ATM
{
    public class CardNotInsertedState : IATMState
    {
        public void InsertCard()
        {
            Console.WriteLine("Card Inserted");
        }

        public void EjectCard()
        {
            Console.WriteLine("You cannot eject the Cardo, as no Card in ATM Machine slot");
        }

        public void EnterPin()
        {
            Console.WriteLine("you cannot enter the pin, as No Card in ATM Machine slot");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("you cannot withdraw money, as No Card in ATM Machine slot");
        }
    }
}
