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

        //function accepts 5 parameters for valiadation
        public string Valid(string customerName, string addressLine1, string postCode, string emailAddress, string accountCreationDate)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the HouseNo is blank
            if (customerName.Length == 0)
            {
                //record the error
                Error = Error + "The customer name may not be blank : ";
            }
            //if the house no is greater than 25 characters
            if (customerName.Length > 25)
            {
                //record the error
                Error = Error + "The customer name must be less than 25 characters : ";
            }

            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(accountCreationDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch

            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
          
            //is the post code blank
            if (postCode.Length == 0)
            {
                //record the error
                Error = Error + "The post code may not be blank : ";
            }
            //if the post code is too long
            if (postCode.Length > 9)
            {
                //record the error
                Error = Error + "The post code must be less than 9 characters : ";
            }

            //is the street blank
            if (addressLine1.Length == 0)
            {
                //record the error
                Error = Error + "The address line may not be blank : ";
            }
            //if the street is too long
            if (addressLine1.Length > 40)
            {
                //record the error
                Error = Error + "The address line must be less than 50 characters : ";
            }
            //is the town blank
            if (emailAddress.Length == 0)
            {
                //record the error
                Error = Error + "The email address may not be blank : ";
            }
            //if the town is too long
            if (emailAddress.Length > 254)
            {
                //record the error
                Error = Error + "The email address must be less than 254 characters : ";
            }
            //return any error messages
            return Error;
        }

        public bool Find(int CustomerID)
        {
            //create instance of data connection
            clsDataConnection DB = new clsDataConnection();
            //add parameter for customer ID to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy data from database to private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mAddressLine1 = Convert.ToString(DB.DataTable.Rows[0]["AddressLine1"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mEmailVerification = Convert.ToBoolean(DB.DataTable.Rows[0]["EmailVerification"]);
                mAccountCreationDate = Convert.ToDateTime(DB.DataTable.Rows[0]["AccountCreationDate"]);
                
                //return worked
                return true;
            }
            //if no record found
            else
            {
                //return false (problem) 
                return false;
            }
        }

    }
}