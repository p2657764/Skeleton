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

        public string Valid(string CustomerName, string AddressLine1, string PostCode, string EmailAddress, bool EmailVerification, string AccountCreationDate)
        {
            return "";
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

        public string Valid(Int32 CustomerID,
                            string CustomerName,
                            string AddressLine1,
                            string PostCode,
                            string EmailAddress,
                            Boolean EmailVerification,
                            DateTime AccountCreationDate)
        //function accepts 7 parameters for valiadation
        //returns string containing error message
        //if no errors blank string returned 
        {
            return "";
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