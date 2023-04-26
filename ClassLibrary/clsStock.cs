using System;

namespace ClassLibrary
{
    public class clsStock
    {
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

        //private date added data member 
        private DateTime mDateAdded;
        //public property for date added
        public DateTime DateAdded
        { 
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the private data
                mDateAdded = value;
            }
        }


        //private data member for stock no 
        private Int32 mStockNo;
        //public property for stock no
        public int StockNo
        {
            get
            {
                //return the private data
                return mStockNo;
            }
            set
            {
                //set the private data
                mStockNo = value;
            }
        }

        //private data member for unit price 
        private Int32 mUnitPrice;
        //public property for unit price
        public int UnitPrice
        {
            get
            {
                //return the private data
                return mUnitPrice;
            }
            set
            {
                //set the private data
                mUnitPrice = value;
            }
        }

        //private data member for stock colour 
        private string mStockColour;
        //public property for stock colour
        public string StockColour
        {
            get
            {
                //return the private data
                return mStockColour;
            }
            set
            {
                //set the private data
                mStockColour = value;
            }
        }

        //private data member for stock name 
        private string mStockName;
        //public property for stock name
        public string StockName
        {
            get
            {
                //return the private data
                return mStockName;
            }
            set
            {
                //set the private data
                mStockName = value;
            }
        }


        //productID private member variable
        private Int32 mProductID;
        //ProductID public property
        public int ProductID
        {
            get
            {
                //this line of code sends data out of the stock
                return mProductID;
            }
            set
            {
                //this line of code allows data into the stock
                mProductID = value;
            }
        }

        public bool Find(int ProductID)
        {
            //set the private data members to test the data value
            mProductID = 22;
            mStockName = "Test name";
            mStockColour = "Test colour";
            mUnitPrice = 3;
            mStockNo = 2;
            mDateAdded = Convert.ToDateTime("11/03/2023");
            mActive = true;
            //always return true
            return true;
        }
    }
}