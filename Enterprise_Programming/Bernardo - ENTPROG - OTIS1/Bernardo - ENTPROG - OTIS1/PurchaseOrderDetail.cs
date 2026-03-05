using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernardo___ENTPROG___OTIS1
{
    public class PurchaseOrderDetail
    {
        public int Id { get; set; }

        public int PurchaseOrderHeaderId { get; set; }

        public int ProductId { get; set; }

        public int Qty { get; set; }

        public decimal Price { get; set; }

        public decimal Amount { get; set; }


        public PurchaseOrderHeader PurchaseOrderHeader { get; set; }

        public Product Product { get; set; }
    }
}
