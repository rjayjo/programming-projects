using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akses.DataModel
{
    public class OrderHeader
    {
        public int Id { get; set; } 

        public int CustomerId { get; set; }

        public string Status { get; set; }
        
        public Customer Customer { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
  