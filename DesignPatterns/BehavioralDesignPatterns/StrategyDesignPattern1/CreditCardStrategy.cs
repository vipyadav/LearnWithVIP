using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern1
{
    public class CreditCardStrategy : IPaymentStrategy
    {
        private String name;
        private String cardNumber;
        private String cvv;
        private String dateOfExpiry;

        public CreditCardStrategy(String nm, String ccNum, String cvv, String expiryDate)
        {
            this.name = nm;
            this.cardNumber = ccNum;
            this.cvv = cvv;
            this.dateOfExpiry = expiryDate;
        }

        public void Pay(int amount)
        {
            System.Console.WriteLine(amount + " paid with credit/debit card");
        }
    }
}
