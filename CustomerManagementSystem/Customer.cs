using System.Collections.Generic;
using CustomerManagementSystem.Common;

namespace CustomerManagementSystem
{
    public class Customer:EntityBase,ILoggable
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
                    if(!string.IsNullOrEmpty(fullName))
                    {
                        fullName += " ";
                    }
                    fullName += FirstName;
                }
                return fullName;  
            }
        }
        public static int InstanceCount { get; set; }
        public string Log()
        {
            var logString = CustomerId + ":" +
                FullName + ":" +
                "Email: " + EmailAddress +
                "Status: " + EntityState.ToString();
                return logString;

        }
        public override string ToString()
        {
            return FullName;
        }

        public override bool Validate()
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