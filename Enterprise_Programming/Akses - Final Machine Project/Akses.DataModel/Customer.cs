using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akses.DataModel
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string? Name { get; set; }
        public string? ContactNo { get; set; }

        public List<OrderHeader> OrderHeaders { get; set; }
    }
}
