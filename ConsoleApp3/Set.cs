using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Set : Goods
    {
        public List<Product> Products { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine($"Продукт: {Name}, Цена: {Price}");
            foreach (Product product in Products)
            {
                product.ShowInfo();
            }
        }
        public override bool InExpired()
        {
             foreach (Product product in Products)
             {
                if (product.InExpired())
                {
                    return true;
                }
             }    
        }    return false;
    }
}
