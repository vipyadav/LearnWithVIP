using Models;
using System;

namespace ChainOfResponsibility1
{
    public class PurchasingManager : Approver
    {
        public override void ProcessRequest(PurchaseOrder purchase)
        {
            if (purchase.Price < 2500)
            {
                Console.WriteLine("{0} approved purchase request #{1}",
                    this.GetType().Name, purchase.RequestNumber);
            }
            else if (NextApprover != null)
            {
                NextApprover.ProcessRequest(purchase);
            }
        }
    }
}
