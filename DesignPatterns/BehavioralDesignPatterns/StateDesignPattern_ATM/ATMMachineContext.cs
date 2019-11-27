using System;

namespace StateDesignPattern_ATM
{
    public class ATMMachineContext : IATMState
    {
        public IATMState CurrentATMState { get; set; }
        public IATMState CardInsertedState { get; set; }
        public IATMState CardNotInsertedState { get; set; }

        public ATMMachineContext()
        {
            CardNotInsertedState = new CardNotInsertedState(this);
            CardInsertedState = new CardInsertedState(this);

            CurrentATMState= CardNotInsertedState;
        }

        public void InsertCard()
        {
            CurrentATMState.InsertCard();
        }

        public void EjectCard()
        {
            CurrentATMState.EjectCard();           
        }

        public void EnterPin()
        {
            CurrentATMState.EnterPin();
        }

        public void WithdrawMoney()
        {
            CurrentATMState.WithdrawMoney();
        }
    }

}
