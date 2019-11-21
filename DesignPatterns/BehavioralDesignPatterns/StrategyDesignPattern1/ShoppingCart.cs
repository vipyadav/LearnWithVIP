using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern1
{
    public class ShoppingCart
    {
        List<Product> items;

        public ShoppingCart()
        {
            items = new List<Product>();
        }

        public void AddItem(Product item)
        {
            items.Add(item);
        }

        public void RemoveItem(Product item)
        {
            items.Remove(item);
        }

        public int CalculateTotal()
        {
            int sum = 0;
            foreach (Product item in items)
            { 
                sum += item.Price;
            }
            return sum;
        }

        public void Pay(IPaymentStrategy paymentMethod)
        {
            int amount = CalculateTotal();
            paymentMethod.Pay(amount);
        }
    }
}
