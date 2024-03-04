using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Goods
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public abstract void ShowInfo();
        public abstract bool InExpired();
    }
}
