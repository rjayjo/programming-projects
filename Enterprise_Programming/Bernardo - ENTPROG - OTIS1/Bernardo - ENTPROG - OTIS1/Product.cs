using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernardo___ENTPROG___OTIS1
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public int? Qty { get; set; }

        [Required]
        public string? Unit { get; set; }

        public DateTime? DateAdded { get; set; }
        
        public DateTime? DateModified { get; set; }

        public List<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
}
