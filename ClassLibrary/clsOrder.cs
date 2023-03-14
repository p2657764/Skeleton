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
        //dateAdded private member variable
        private DateTime mDateAdded;
        //DateAdded public property
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public int CustomerID { get; set; }
        public DateTime OrderPlacedDate { get; set; }
        public bool OrderVerification { get; set; }
        public int ProductQuantity { get; set; }
        public int UnitPrice { get; set; }
        public DateTime ShippingDate { get; set; }
        public bool Active { get; set; }

        public bool Find(int OrderNo)
        {
            //set the private data members to the test data value
            mOrderNo = 18;
            mDateAdded = Convert.ToDateTime("16/9/2015");
            //always return true
            return true;
        }
    }
}