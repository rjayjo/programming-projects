using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akses.DataModel
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderHeaderId { get; set; }
        public int MedicineId { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public DateTime? DateAdded { get; set; }

        public MedicineInventory MedicineInventory { get; set; }
        public OrderHeader OrderHeader { get; set; }
    }
}
