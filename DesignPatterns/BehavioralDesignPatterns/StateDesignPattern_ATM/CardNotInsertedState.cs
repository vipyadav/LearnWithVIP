using System;

namespace StateDesignPattern_ATM
{
    public class CardNotInsertedState : IATMState
    {
        public CardNotInsertedState(ATMMachineContext context)
        {
            Context = context;
        }

        public ATMMachineContext Context { get; set; }

        public void InsertCard()
        {
            Console.WriteLine("Card Inserted");
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
            Console.WriteLine("You cannot eject the Card, as no Card in ATM Machine slot");
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
            Console.WriteLine("you cannot enter the pin, as No Card in ATM Machine slot");
        }

        public void WithdrawCash()
        {
            Console.WriteLine("you cannot withdraw money, as No Card in ATM Machine slot");
        }
    }
}
