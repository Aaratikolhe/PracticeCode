using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; set; }

        public DateTimeOffset? OrderDate { get; set; }

        public bool Validate()
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
    }
}
