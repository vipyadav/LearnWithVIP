using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern1
{
    public class PaypalStrategy : IPaymentStrategy
    {
        private String emailId;
        private String password;

        public PaypalStrategy(String email, String pwd)
        {
            emailId = email;
            password = pwd;
        }
        
        public void Pay(int amount)
        {
            System.Console.WriteLine(amount + " paid using Paypal.");
        }

    }
}
