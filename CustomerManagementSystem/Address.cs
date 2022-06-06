﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem
{
    public class Address
    {
        public Address()
        {

        }
        public Address(int adressId)
        {
            AddressId=adressId;
        }
        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (PostalCode == null)
                isValid = false;
            return isValid;
        }
    }
}
