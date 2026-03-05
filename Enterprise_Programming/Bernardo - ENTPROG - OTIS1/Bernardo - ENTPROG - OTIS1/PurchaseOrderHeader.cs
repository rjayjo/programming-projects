using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernardo___ENTPROG___OTIS1
{
    public class PurchaseOrderHeader
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int SupplierId { get; set; }

        public string Status { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime DateReceived { get; set; }


        public Supplier Supplier { get; set; }

        public List<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
}
