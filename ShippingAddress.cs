using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class ShippingAddress
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public Guid CustomerId { get; set; }
    }
}
