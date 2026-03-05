using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akses.DataModel
{
    public class MedicineInventory
    {
        [Key]
        public int MedicineID { get; set; }

        public int? Quantity { get; set; }

        public string? MedicineName { get; set; }

        public DateTime? MFGDate{ get; set; }

        public DateTime? ExpiryDate { get; set; }

        public decimal? Price { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

    }
}
