using System;

namespace ClassLibrary
{
    public class ClsStaff
    {
        public bool Active { get; set; }
        
        public string Name { get; set; }
        public string Department { get; set; }
        public string Wage { get; set; }
        public bool UpdateCatalogue { get; set; }

        public bool Find(int staffNo)
        {
            mStaffNo = 21;
            mDateAdded = Convert.ToDateTime("16/09/2015");
            return true;
        }

        private Int32 mStaffNo;

        private DateTime mDateAdded;

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


        public Int32 AddressNo
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

        public int staffWage { get; set; }
        public string Role { get; set; }
        public string StartDate { get; set; }

        public bool Find(string staffName)
        {
            throw new NotImplementedException();
        }
    }
}