using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product
    {
        public Product(string code, int price)
        {
            ProductCode = code;
            Price = price;
        }

        public string ProductCode { get; set; }
        public int Price { get; set; }
    }
}
