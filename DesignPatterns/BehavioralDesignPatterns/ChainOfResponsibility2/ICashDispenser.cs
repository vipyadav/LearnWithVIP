using Models;

namespace ChainOfResponsibility2
{
    public interface ICashDispenser
    {
        void SetNextDispenser(ICashDispenser nextDispenser);

        void Dispense(Currency cur);
    }
}
