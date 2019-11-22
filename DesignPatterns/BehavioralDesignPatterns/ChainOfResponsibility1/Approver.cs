using Models;

namespace ChainOfResponsibility1
{
    public abstract class Approver
    {
        protected Approver NextApprover;

        public void SetNextApprover(Approver successor)
        {
            NextApprover = successor;
        }

        public abstract void ProcessRequest(PurchaseOrder purchase);
    }
}
