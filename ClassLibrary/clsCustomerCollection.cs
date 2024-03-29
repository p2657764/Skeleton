﻿using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        void PopulateArray(clsDataConnection DB)
        {
            //populates array list based on data table in parameter DB
            //variable for index
            Int32 Index = 0;
            //var to store record count
            Int32 RecordCount;
            //get count of records
            RecordCount = DB.Count;
            //clear private array list
            mCustomerList = new List<clsCustomer>();
            //while records to process
            while (Index < RecordCount)
            {
                //create blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in from current record
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                ACustomer.AddressLine1 = Convert.ToString(DB.DataTable.Rows[Index]["AddressLine1"]);
                ACustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                ACustomer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                ACustomer.EmailVerification = Convert.ToBoolean(DB.DataTable.Rows[Index]["EmailVerification"]);
                ACustomer.AccountCreationDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["AccountCreationDate"]);
                //add record to private data member
                mCustomerList.Add(ACustomer);
                //point to next record
                Index++;
            }
        }

        public List<clsCustomer> CustomerList
        {
            get
            {
                //return private data
                return mCustomerList;
            }
            set
            {
                //set private data
                mCustomerList = value;
            }
        }

        public int Count
        {
            get
            {
                //return count of the list
                return mCustomerList.Count;
            }
            set
            {
                //worry about later
            }
        }

        //public property for ThisCustomer
        public clsCustomer ThisCustomer
        {
            get
            {
                //return private data
                return mThisCustomer;
            }

            set
            {
                //set private data
                mThisCustomer = value;
            }
        }


        //constructor for the class
        public clsCustomerCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate array list with data table
            PopulateArray(DB);
        }


        public int Add()
        {
            //adds new record to database based on vlaues of mThisCustomer
            //connects to database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for stored procedure
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@AddressLine1", mThisCustomer.AddressLine1);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@EmailVerification", mThisCustomer.EmailVerification);
            DB.AddParameter("@AccountCreationDate", mThisCustomer.AccountCreationDate);
            //execute query returning primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //adds new record to database based on vlaues of mThisCustomer
            //connects to database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@AddressLine1", mThisCustomer.AddressLine1);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@EmailVerification", mThisCustomer.EmailVerification);
            DB.AddParameter("@AccountCreationDate", mThisCustomer.AccountCreationDate);
            //execute query returning primary key value
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //delete record pointed to by thisCustomer
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByCustomerName(string CustomerName)
        {
            //fileters records based on full or partial name
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //send CustomerName parameter to database
            DB.AddParameter("@CustomerName", CustomerName);
            //execture stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerName");
            //populate arry list with data table 
            PopulateArray(DB);
        }
    }
}
