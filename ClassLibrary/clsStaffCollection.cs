using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {

        //private data member for the list
        List<ClsStaff> mStaffList = new List<ClsStaff>();

        public List<ClsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {
                //TODO
            }
        }
        public ClsStaff ThisStaff { get; set; }

        public clsStaffCollection()
        {
            //var for index
            Int32 Index = 0;
            //var to store count
            Int32 RecordCount = 0;
            //obj for data connection
            clsDataConnection DB = new clsDataConnection();
            //exec stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create blank staff
                ClsStaff staff = new ClsStaff();
                staff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                staff.Department = Convert.ToString(DB.DataTable.Rows[Index]["Department"]);
                staff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                staff.Role = Convert.ToString(DB.DataTable.Rows[Index]["Role"]);
                staff.StaffNo = Convert.ToString(DB.DataTable.Rows[Index]["StaffNo"]);
                staff.StaffWage = Convert.ToString(DB.DataTable.Rows[Index]["StaffWage"]);
                staff.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                staff.UpdateCatalogue = Convert.ToBoolean(DB.DataTable.Rows[Index]["UpdateCatalogue"]);
                //add to record
                mStaffList.Add(staff);
                //point at the next record
                Index++;

            }


        }
    }
}