using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Classes
{
    internal class Customer
    {
        public int custometId { get; set; }
        public string customerName { get; set; }
        public TimeOnly arrivalTime { get; set; }
        public Customer()
        {

        }
        public Customer(int custometId, string customerName, TimeOnly arrivalTime)
        {
            this.custometId = custometId;
            this.customerName = customerName;
            this.arrivalTime = arrivalTime;
        }
    }
}
