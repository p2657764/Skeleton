using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member for ThisOrder
        clsOrder mThisOrder = new clsOrder();
        public List<clsOrder> OrderList
        {
            get
            {
                //return private data
                return mOrderList;
            }
            set
            {
                //set private data
                mOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                //return count of the list
                return mOrderList.Count;
            }
            set
            {
                //set private data
            }
        }
        public clsOrder ThisOrder
        {
            get
            {
                //return private data
                return mThisOrder;
            }
            set
            {
                //set private data
                mThisOrder = value;
            }
        }

        //consturoct for the class
        public clsOrderCollection()
        {
            //variable for index
            Int32 Index = 0;
            //variable to store record count
            Int32 RecordCount = 0;
            //create instance of data connection
            clsDataConnection DB = new clsDataConnection();
            //executre stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        public int Add()
        {
            //adding new records
            //connecting to the databse
            clsDataConnection DB = new clsDataConnection();
            //set parameters for stored procedure
            DB.AddParameter("@OrderPlacedDate", mThisOrder.OrderPlacedDate);
            DB.AddParameter("@OrderVerification", mThisOrder.OrderVerification);
            DB.AddParameter("@ProductQuantity", mThisOrder.ProductQuantity);
            DB.AddParameter("@UnitPrice", mThisOrder.UnitPrice);
            DB.AddParameter("@ShippingDate", mThisOrder.ShippingDate);
            //execute query returning primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }
        public void Update()
        {
            //update an existing record based on the values of thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderPlacedDate", mThisOrder.OrderPlacedDate);
            DB.AddParameter("@OrderVerification", mThisOrder.OrderVerification);
            DB.AddParameter("@ProductQuantity", mThisOrder.ProductQuantity);
            DB.AddParameter("@UnitPrice", mThisOrder.UnitPrice);
            DB.AddParameter("@ShippingDate", mThisOrder.ShippingDate);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }
        public void Delete()
        {
            //deletes the record pointed to by thisorder
            //conect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the stored procedure
            DB.AddParameter("OrderID", mThisOrder.OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByOrderPlacedDate(string OrderPlacedDate)
        {
            //filters the records based ona  full or partial orderplaceddate
            //connect tot database
            clsDataConnection DB = new clsDataConnection();
            //send the orderplaceddate paramaeter to the database
            DB.AddParameter("@OrderPlacedDate", OrderPlacedDate);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderPlacedDate");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var to the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the prvate array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();
                //read fields from current record
                AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.OrderPlacedDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderPlacedDate"]);
                AnOrder.OrderVerification = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderVerification"]);
                AnOrder.ProductQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductQuantity"]);
                AnOrder.UnitPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["UnitPrice"]);
                AnOrder.ShippingDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ShippingDate"]);
                //add record to private data memeber
                mOrderList.Add(AnOrder);
                //points to next record
                Index++;
            }
        }
    }
}
