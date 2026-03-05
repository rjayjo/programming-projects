using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akses.DataModel
{
    
    public class MedicineRequest
    {
        [Key]
        public int RequestID { get; set; }

        [Required]
        public string Request { get; set; } //Medicine Name, Description, Etc..
        [Required]
        public string Quantity { get; set; }
        [Required]
        public string NameOfRequester { get; set; }
        [Required]
        public DateTime DateRequested { get; set; } // Date Time Now
        [Required]
        public DateTime DateNeeded { get; set; } // Option to Set Date
        [Required]
        public string ContactNoOfRequester { get; set; }


    }
}
