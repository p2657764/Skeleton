using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        
        public string CustomerName { get; set; }
        public string AddressLine1 { get; set; }
        public string PostCode { get; set; }
        public string EmailAddress { get; set; }
        public bool EmailVerification { get; set; }
        public DateTime AccountCreationDate { get; set; }

        public string Valid(string PostCode)
        {
            return "";
        }
    }
}