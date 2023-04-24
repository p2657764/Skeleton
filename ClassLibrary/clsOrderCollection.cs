using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
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
        public clsOrder ThisOrder { get; set; }

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
            //get count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();
                //read fields from current record
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
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
