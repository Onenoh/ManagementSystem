using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Orders
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public Guid CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsStatus { get; set; }
        public string ShippingDetails { get; set; }

    }
}
