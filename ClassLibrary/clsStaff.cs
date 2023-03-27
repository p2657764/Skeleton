﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class ClsStaff
    {
        private Boolean mActive;
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        private string mStaffId;
        public string StaffId
        {
            get
            {
                return mStaffId;
            }
            set
            {
                mStaffId = value;
            }
        }

        private Boolean mUpdateCatalogue;

        public bool UpdateCatalogue
        {
            get
            {
                return mUpdateCatalogue;
            }
            set
            {
                mUpdateCatalogue = value;
            }
        }

        private string mStaffWage;

        public string StaffWage
        {
            get
            {
                return mStaffWage;
            }
            set
            {
                mStaffWage = value;
            }
        }

        private string mName;

        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        private string mDepartment;

        public string Department
        {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }
        }

        private string mRole;

        public string Role
        {
            get
            {
                return mRole;
            }
            set
            {
                mRole = value;
            }
        }

        private DateTime mStartDate;

        public DateTime StartDate
        {
            get
            {
                return mStartDate;
            }
            set
            {
                mStartDate = value;
            }
        }




        public bool Find(int staffNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByAddressNo");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {


                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StartDate"]);
                mRole = Convert.ToString(DB.DataTable.Rows[0]["Role"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                mUpdateCatalogue = Convert.ToBoolean(DB.DataTable.Rows[0]["UpdateCatalogue"]);
                mStaffWage = Convert.ToInt32(DB.DataTable.Rows[0]["Wage"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                //return that everything worked okay
                return true;
            }
            else
            {

            }
            return false;
            }
        }

       
       
        public bool Find(string staffName)
        {
            throw new NotImplementedException();
        }
    }
}