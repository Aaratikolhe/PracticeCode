using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagementSystem.Common;

namespace CustomerManagementSystem
{
    public class Order:EntityBase,ILoggable
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems= new List<OrderItem>();
        }

        public int OrderId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int CustomerId { get; set; }
        public string ShippingAddressId { get; set; }
        public override bool Validate()
        {
            var isValid = true;
            if (OrderDate==null)
                isValid = false;

            return isValid;
        }

        public Order Retrieve(int CustomerId)
        {
            return new Order();
        }

        public List<Order> Retrieve()  //get all customers
        {
            return new List<Order>();

        }
        public bool Save()
        {
            return true;
        }

        public string Log()
        {
            {
                var logString = OrderId + ":" +
                    OrderDate + ":" +
                     "Status: " + EntityState.ToString();
                return logString;

            }
        }
    }
}
