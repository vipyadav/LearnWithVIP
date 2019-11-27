using System;

namespace StateDesignPattern_ATM
{
    public class ATMMachineContext : IATMState
    {
        public IATMState atmMachineState { get; set; }

        public ATMMachineContext()
        {
            atmMachineState = new CardNotInsertedState();
        }

        public void InsertCard()
        {
            atmMachineState.InsertCard();
            // Card has been inserted so internal state of ATM Machine
            // has been changed to 'CardNotInsertedState'

            if (atmMachineState is CardNotInsertedState)
            {
                atmMachineState = new CardInsertedState();
                Console.WriteLine("ATM Machine internal state has been moved to : "
                                + atmMachineState.GetType().Name);
            }
        }

        public void EjectCard()
        {
            atmMachineState.EjectCard();
            // Card has been ejected so internal state of ATM Machine
            // has been changed to 'CardNotInsertedState'

            if (atmMachineState is CardInsertedState)
            {
                atmMachineState = new CardNotInsertedState();
                Console.WriteLine("ATM Machine internal state has been moved to : "
                                + atmMachineState.GetType().Name);
            }
        }

        public void EnterPin()
        {
            atmMachineState.EnterPin();
        }

        public void WithdrawMoney()
        {
            atmMachineState.WithdrawMoney();
        }
    }

}
