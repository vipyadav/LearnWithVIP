using System;

namespace StateDesignPattern_ATM
{
    public class NoCashState : IATMState
    {
        public NoCashState(ATMMachineContext context)
        {
            Context = context;
        }

        public ATMMachineContext Context { get; set; }

        public void InsertCard()
        {
            Console.WriteLine("We don't have any money.");

            Context.CurrentATMState = Context.CardNotInsertedState;

            Console.WriteLine("Your card is ejected");
        }

        public void EjectCard()
        {
            Console.WriteLine("We don't have any money.");
            Console.WriteLine("There is no card to eject.");
        }

        public void EnterPin()
        {
            Console.WriteLine("We don't have any money.");
        }

        public void WithdrawCash()
        {
            Console.WriteLine("We don't have any money.");
        }
    }
}
