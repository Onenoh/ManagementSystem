using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Product
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal QuantityinStock { get; set;}
        
    }
}
