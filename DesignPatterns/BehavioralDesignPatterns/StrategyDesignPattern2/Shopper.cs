using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern2
{
    public class Shopper
    {
        List<Product> products = new List<Product>();
        IFestiveSaleStrategy festiveSaleStrategy;

       // public IFestiveSaleStrategy Strategy { get; set; }

        double discount = 0;

        public void AddToCart(Product item)
        {
            products.Add(item);
        }

        public void ApplyFestiveDiscount()
        {
            var amount = CalculateCartValue();
            discount= festiveSaleStrategy.ApplyDiscount(amount);            
        }

        // Usually, the Context allows replacing a Strategy object at runtime.
        public void SetStrategy(IFestiveSaleStrategy _festiveSaleStrategy)
        {
            festiveSaleStrategy = _festiveSaleStrategy;
        }

        private int CalculateCartValue()
        {
            int sum = 0;
            foreach (Product item in products)
            {
                sum += item.Price;
            }
            return sum;
        }

        public void PrintBill()
        {
            var bill = CalculateCartValue() - discount;
            Console.WriteLine("Total due: " + bill);
            this.products.Clear();
        }

    }
}
