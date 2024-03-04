using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Product : Goods
    {
        public override void ShowInfo()
        {
            Console.WriteLine($"Продукт: {Name}, Цена: {Price}, Дата производства: {ProductionDate}, Срок годности: {ExpirationDate}");
        }
        public override bool InExpired()
        {
            return DateTime.Today > ExpirationDate;
        }
    }
}
