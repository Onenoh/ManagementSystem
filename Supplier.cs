using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Supplier
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string ContactDetails { get; set; }
        public string Address { get; set; }
        public List<SupplierContactDetails> SupplierContactDetails { get; set; } = new List<SupplierContactDetails>();
    }
}
