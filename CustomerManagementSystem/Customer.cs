using System.Collections.Generic;

namespace CustomerManagementSystem
{
    public class Customer
    {
        public Customer():this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList=new List<Address>();
        }
        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        private string firstName;
        public string FirstName { get => firstName; set => firstName = value; }
        private string lastName;     
        public string LastName { get => lastName; set => lastName = value; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrEmpty(FirstName))
                {
                    if(!string.IsNullOrEmpty(FullName))
                    {
                        fullName += " ";
                    }
                    fullName += FirstName;
                }
                return fullName;  
            }
        }
        public static int InstanceCount { get; set; }
   
        public bool Validate()
        {
             var isValid = true;
             if (string.IsNullOrEmpty(LastName))
                isValid=false;
             if(string.IsNullOrEmpty(EmailAddress))
                isValid=false;

             return isValid;    
        }
    }
}