using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the order no property
        private Int32 mOrderNo;
        //OrderID public property
        public Int32 OrderID
        { 
            get
            {
                //this line of code sends data out of the property
                return mOrderNo;
            }
            set
            {
                //this line of code allows data into the property
                mOrderNo = value;
            }
        }

        //private data member for active
        private Boolean mActive;
        //public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }

        //dateAdded private member variable
        private DateTime mOrderPlacedDate;
        //DateAdded public property
        public DateTime OrderPlacedDate
        {
            get
            {
                return mOrderPlacedDate;
            }
            set
            {
                mOrderPlacedDate = value;
            }
        }

        private bool mOrderVerification;
        public bool OrderVerification
        {
            get
            {
                return mOrderVerification;
            }
            set
            {
                mOrderVerification = value;
            }
        }

        private Int32 mProductQuantity;
        public Int32 ProductQuantity
        {
            get
            {
                return mProductQuantity;
            }
            set
            {
                mProductQuantity = value;
            }
        }

        private Int32 mUnitPrice;
        public Int32 UnitPrice
        {
            get
            {
                return mUnitPrice;
            }
            set
            {
                mUnitPrice = value;
            }
        }

        private DateTime mShippingDate;
        public DateTime ShippingDate
        {
            get
            {
                return mShippingDate;
            }
            set
            {
                mShippingDate = value;
            }
        }
        
        //function accepts 5 parameters for validation
        public string Valid (string orderPlacedDate, string productQuantity, string unitPrice, string shippingDate)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store data values
            DateTime DateTemp;
            //copy the dateadde value to the datetemp variable
            try
            {
                DateTemp = Convert.ToDateTime(orderPlacedDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past: ";
                }
                //check to see if the date is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future: ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date: ";
            }
            //check to see if the product quanity is 0
            if (ProductQuantity == 0)
            {
                //record the error
                Error = Error + "The product quantity cannot be 0: ";
            }
            //check to see if the unit price is 0
            if (UnitPrice == 0)
            {
                //record the error 
                Error = Error + "The unit price cannot be 0: ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(ShippingDate);
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
            //return any error messages
            return Error;
        }
        public bool Find(int OrderNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to the search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mOrderPlacedDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderPlacedDate"]);
                mOrderVerification = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderVerification"]);
                mProductQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ProductQuantity"]);
                mUnitPrice = Convert.ToInt32(DB.DataTable.Rows[0]["UnitPrice"]);
                mShippingDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ShippingDate"]);

                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }

        }
    }
}