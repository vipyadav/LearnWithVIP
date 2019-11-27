
namespace StateDesignPattern_ATM
{
    public interface IATMState
    {
        void InsertCard();
        void EjectCard();
        void EnterPin();
        void WithdrawMoney();
    }

}
