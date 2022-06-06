using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem
{
    public class OrderItem
    {
        public int OrderItemId { get;private set; }
        public int ProductId { get;private set; }
        public decimal? PurchasePrice { get;set; }  
        public int Quantity { get;set; }

        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        public bool Validate()
        {
            var isValid = true;
            if (Quantity<=0)
                isValid = false;
            if (ProductId<=0)
                isValid = false;
            if(PurchasePrice==0)
                isValid=false;
            return isValid;
        }

        public OrderItem Retrieve(int OrderItemId)
        {
            return new OrderItem();
        }

        public List<OrderItem> Retrieve()  //get all customers
        {
            return new List<OrderItem>();

        }
        public bool Save()
        {
            return true;
        }
    }
}
