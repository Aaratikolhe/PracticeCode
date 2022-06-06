using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Band Street";
                address.StreetLine2 = "Mahabal Road";
                address.City = "Jalgaon";
                address.State = "Maharashtra";
                address.PostalCode = "111221";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int CustomerId)
        {
            var addressList=new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Band Street",
                StreetLine2 = "Mahabal Road",
                City = "Jalgaon",
                State = "Maharashtra",
                PostalCode = "111221"
            };
            addressList.Add(address);
            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green park",
                StreetLine2 = "Nelson Road",
                City = "Pune",
                State = "Maharashtra",
                PostalCode = "111222"

            };
            addressList.Add(address);
            return addressList;
        }
        public bool Save(Address address)
        {
            return true;
        }
    }
}
