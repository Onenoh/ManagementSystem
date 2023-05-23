using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Customers
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string ContactDetails { get; set; } 
        public List<ShippingAddress> Shippingaddresses { get; set; } = new List<ShippingAddress>();
        public List<BillingAddress> Billingaddress { get; set; } = new List<BillingAddress>();
        public List<ContactDetails> CustomerContacts { get; set; } = new List<ContactDetails>();
    }
}
