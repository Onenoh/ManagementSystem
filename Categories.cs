using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Categories
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ProductId { get; set; }
    }
}
