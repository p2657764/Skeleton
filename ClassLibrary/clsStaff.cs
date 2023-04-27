using System;
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

        private string mStaffNo;
        public string StaffNo
        {
            get
            {
                return mStaffNo;
            }
            set
            {
                mStaffNo = value;
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

        public string Valid(string staffNo, string staffWage, string staffRole, string staffDepartment, string startDate)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store data values
            DateTime DateTemp;
            //if the staff No is blank
            if (staffNo.Length == 0)
            {
                //record the error
                Error = Error + "The staff no may not be blank : ";
            }
            if (staffNo.Length > 6)
            {
                //record the error
                Error = Error = "The staff no must be less than 6 characters : ";
            }
            try
            {
                //copy the dateAdded value to the date temp variable
                DateTemp = Convert.ToDateTime(StartDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date wasn't a valid date : ";
            }
            //is the Department blank
            if (staffDepartment.Length == 0)
            {
                Error = Error + "The department is blank : ";
            }
            //if its too long
            if(staffDepartment.Length > 20)
            {
                Error = Error + "The department must be less than 20 characters : ";
            }
            if (staffWage.Length == 0)
            {
                Error = Error + "The wage may not be blank : ";
            }
            if (staffWage.Length > 50)
            {
                Error = Error + "The wage must be less than 50 characters : ";
            }
            if (staffRole.Length == 0)
            {
                Error = Error + "The staff role may not be blank : ";
            }
            if (staffRole.Length > 50)
            {
                Error = Error + "The staff role must be less than 50 characters : ";
            }

            //return any error messages
            return Error;
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




        public bool Find(int staffId)
        {
            mDepartment = "Managment";
            mActive = true;
            mName = "Alfie Nickson";
            mStaffNo = 21;
            mStartDate = Convert.ToDateTime("11/01/2001");
            mStaffWage = 200;
            mUpdateCatalogue = true;
            mRole = "P and C";

            return true;

            /*//create an instance of the data connection
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
            }*/
        }


    }
}
