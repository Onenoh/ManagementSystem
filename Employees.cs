using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Employees
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Position { get; set; }
        public List<ContactDetails> employeecontact { get; set; } = new List<ContactDetails>();
    }
}
