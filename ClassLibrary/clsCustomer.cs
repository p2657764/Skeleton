using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for customer ID
        private Int32 mCustomerID;

        //customer ID public property
        public Int32 CustomerID 
        { 
            get
            {
                //sends data out of property
                return mCustomerID;
            }
            set
            {
                //allows data into property
                mCustomerID = value;
            }
        }

        //private data member for customer name
        private string mCustomerName;

        //customer name public property
        public string CustomerName
        {
            get
            {
                //sends data out of property
                return mCustomerName;
            }
            set
            {
                //allows data into property
                mCustomerName = value;
            }
        }

        //private data member for address line
        private string mAddressLine1;

        //address line public property
        public string AddressLine1
        {
            get
            {
                //sends data out of property
                return mAddressLine1;
            }
            set
            {
                //allows data into property
                mAddressLine1 = value;
            }
        }

        //private data member for post code
        private string mPostCode;

        //post code public property
        public string PostCode
        {
            get
            {
                //sends data out of property
                return mPostCode;
            }
            set
            {
                //allows data into property
                mPostCode = value;
            }
        }

        //private data member for email address
        private string mEmailAddress;

        //email address public property
        public string EmailAddress
        {
            get
            {
                //sends data out of property
                return mEmailAddress;
            }
            set
            {
                //allows data into property
                mEmailAddress = value;
            }
        }

        //private data member for email verification
        private Boolean mEmailVerification;

        //email verification public property
        public bool EmailVerification
        {
            get
            {
                //sends data out of property
                return mEmailVerification;
            }
            set
            {
                //allows data into property
                mEmailVerification = value;
            }
        }

        //private data member for account creation date
        private DateTime mAccountCreationDate;

        //account creation date public property
        public DateTime AccountCreationDate
        {
            get
            {
                //sends data out of property
                return mAccountCreationDate;
            }
            set
            {
                //allows data into property
                mAccountCreationDate = value;
            }
        }

        public string Valid(string PostCode)
        {
            return "";
        }

        public bool Find(int AddressNo)
        {
            //set the private data members to the test data value
            mCustomerID = 14;
            mCustomerName = "Test Name";
            mAddressLine1 = "TestAddressLine";
            mPostCode = "TestPostCode";
            mEmailAddress = "TestEmailAddress";
            mEmailVerification = true;
            mAccountCreationDate = Convert.ToDateTime("15/07/2003");
            //always return true
            return true;
        }

    }
}