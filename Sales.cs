using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Sales
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public DateTime Date { get; set; }
        public Guid CustomerId { get; set; }
        public Guid EmployeesId { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
