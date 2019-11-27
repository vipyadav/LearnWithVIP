namespace StateDesignPattern_ATM
{
    public class ATMMachineContext : IATMState
    {
        public ATMMachineContext()
        {
            // These can be moved into Methods like GetXXXState() {return new CardInsertedState(this) }
            CardNotInsertedState = new CardNotInsertedState(this);
            CardInsertedState = new CardInsertedState(this);
            NoCashState = new NoCashState(this);

            CurrentATMState = CardNotInsertedState;
        }

        public IATMState CurrentATMState { get; set; }
        public IATMState CardInsertedState { get; set; }
        public IATMState CardNotInsertedState { get; set; }
        public IATMState NoCashState { get; set; }

        public int CashInMachine { get; set; } = 5000;

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

        public void WithdrawCash()
        {
            CurrentATMState.WithdrawCash();
        }
    }

}
