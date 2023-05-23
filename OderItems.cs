using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class OderItems
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal PriceAtTheTimeOfPurchace { get; set; }
    }
}
