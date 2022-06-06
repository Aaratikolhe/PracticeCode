using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem
{
    public class CustomerRepository
    { 
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository { get; set; }
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if(customerId==1)
            {
                customer.EmailAddress = "abcd@mail.com";
                customer.FirstName = "Aarati";
                customer.LastName = "Kolhe";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }
        public bool Save()
        {
            return true;
        }

    }
}
