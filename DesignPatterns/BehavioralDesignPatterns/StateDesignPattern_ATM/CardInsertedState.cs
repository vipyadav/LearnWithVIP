using System;

namespace StateDesignPattern_ATM
{
    public class CardInsertedState : IATMState
    {
        public CardInsertedState(ATMMachineContext context)
        {
            Context = context;
        }

        public ATMMachineContext Context { get; set; }

        public void InsertCard()
        {
            Console.WriteLine("You can only insert one card at a time.");
            // Card has been inserted so internal state of ATM Machine
            // has been changed to 'CardNotInsertedState'

            if (Context.CurrentATMState is CardNotInsertedState)
            {
                Context.CurrentATMState = Context.CardInsertedState;
                Console.WriteLine("ATM Machine internal state has been moved to : "
                                + Context.CurrentATMState.GetType().Name);
            }
        }

        public void EjectCard()
        {
            Console.WriteLine("Your Card is ejected");
            // Card has been ejected so internal state of ATM Machine has been changed to 'CardNotInsertedState'
            if (Context.CurrentATMState is CardInsertedState)
            {
                Context.CurrentATMState = Context.CardNotInsertedState;
                Console.WriteLine("ATM Machine internal state has been moved to : "
                                + Context.CurrentATMState.GetType().Name);
            }
        }

        public void EnterPin()
        {
            Console.WriteLine("Pin number has been entered correctly");
        }

        public void WithdrawCash()
        {
            if (Context.CashInMachine > 0)
            {
                Context.CashInMachine = 0;
                Context.CurrentATMState = Context.NoCashState;
                Console.WriteLine("Rs. 5,000.00 has been withdrawn.");
            }  
            else
            {
                Console.WriteLine("You don't have cash available.");
                Context.CurrentATMState = Context.NoCashState;
            }
        }
    }

}
