using Akses.DataModel;

namespace Akses.App.Models
{
    public class PurchaseOrderVM
    {
        public PurchaseOrderVM()
        {
            Status = "";
            Customer = new Customer();
            Customer.OrderHeaders = new List<OrderHeader>();
            Details = new List<OrderDetail>();
        }
        public bool EditMode { get; set; }

        public int Id { get; set; }
        
        public int CustomerId { get; set; }

        public string Status { get; set; }

        public Customer Customer { get; set; }

        public List<OrderDetail> Details { get; set; }
    }

    public class OrderStatus
    {
        public const string Pending = "Pending Order";

        public const string Complete = "Purchase Order Complete";

        public const string Cancelled = "Order Cancelled";
    }
}
