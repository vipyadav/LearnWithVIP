using System;

namespace StateDesignPattern_ATM
{
    public class CardInsertedState : IATMState
    {
        public void InsertCard()
        {
            Console.WriteLine("You can only insert one card at a time.");
        }
        public void EjectCard()
        {
            Console.WriteLine("Your Card is ejected");
        }
        public void EnterPin()
        {
            Console.WriteLine("Pin number has been entered correctly");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine("Money has been withdrawn");
        }
    }

}
