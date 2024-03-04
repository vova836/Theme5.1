using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
        List<Goods> goodsList = new List<Goods>();

        goodsList.Add(new Product { Name = "Apple", Price = 1.50m, ProductionDate = new DateTime(2022, 1, 1), ExpirationDate = new DateTime(2022, 1, 15) });
        goodsList.Add(new Batch { Name = "Milk", Price = 2.00m, Quantity = 10, ProductionDate = new DateTime(2022, 1, 1), ExpirationDate = new DateTime(2022, 1, 10) });
        
        Set set = new Set 
        { 
            Name = "Fruit Set", 
            Price = 5.00m, 
            Products = new List<Product> 
            { 
                new Product { Name = "Banana", Price = 0.50m, ProductionDate = new DateTime(2022, 1, 1), ExpirationDate = new DateTime(2022, 1, 5) }, 
                new Product { Name = "Orange", Price = 0.75m, ProductionDate = new DateTime(2022, 1, 1), ExpirationDate = new DateTime(2022, 1, 7) } 
            } 
        };
        goodsList.Add(set);

        foreach (Goods item in goodsList)
        {
            item.DisplayInfo();
            if (item.IsExpired())
            {
                Console.WriteLine("Expired");
            }
            else
            {
                Console.WriteLine("Not Expired");
            }
        }
    }
}
