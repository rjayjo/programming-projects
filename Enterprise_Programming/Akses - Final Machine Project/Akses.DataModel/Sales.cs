using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akses.DataModel
{
    public class Sales
    {
        [Key]
        public int EntryID { get; set; }

        public string MedicineName { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public decimal Amount { get; set; }

        public DateTime DatePurchased { get; set; }
    }
}
