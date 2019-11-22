using Models;
using System;

namespace ChainOfResponsibility1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the chain links
            Approver vipin = new HeadChef();
            Approver akhilesh = new PurchasingManager();
            Approver adarsh = new GeneralManager();

            //Create the chain
            vipin.SetNextApprover(akhilesh);
            akhilesh.SetNextApprover(adarsh);

            // Generate and process purchase requests
            PurchaseOrder p = new PurchaseOrder(1, 20, 69, "Spices");
            vipin.ProcessRequest(p);

            p = new PurchaseOrder(2, 300, 1389, "Fresh Veggies");
            vipin.ProcessRequest(p);

            p = new PurchaseOrder(3, 500, 4823.99, "Beef");
            vipin.ProcessRequest(p);

            p = new PurchaseOrder(4, 4, 12099, "Ovens");
            vipin.ProcessRequest(p);

            Console.ReadKey();
        }
    }
}
