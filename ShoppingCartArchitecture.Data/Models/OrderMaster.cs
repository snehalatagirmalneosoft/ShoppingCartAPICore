using System;
using System.Collections.Generic;

namespace ShoppingCartArchitecture.Data.Models
{
    public partial class OrderMaster
    {
        public OrderMaster()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int? UserId { get; set; }
        public string ShippingAddress { get; set; }
        public string ReceiverMobileNumber { get; set; }
        public string BillingMode { get; set; }
        public decimal? GrossAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public string ReceiverEmailId { get; set; }
        public string ReceiverFirstName { get; set; }
        public string ReceiverLastName { get; set; }

        public ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
