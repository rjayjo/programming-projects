using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bernardo___ENTPROG___OTIS1
{
    public class Supplier 
    {
        
        public int SupplierID { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Representative { get; set; }
        [Required]
        public string ContactNo { get; set; }
       
        public DateTime DateAdded { get; set; }
       
        public DateTime DateModified { get; set; } 


        public List<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

    }

  
}
