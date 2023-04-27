using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection staff = new clsStaffCollection();

            Assert.IsNotNull(staff);
        }
        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection staff = new clsStaffCollection();
            List<ClsStaff> TestList = new List<ClsStaff>();
            ClsStaff TestItem = new ClsStaff();
            //set properties
            TestItem.Active = true;
            TestItem.StaffNo = "21";
            TestItem.StaffWage = "200";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.Department = "some dept";
            TestItem.Name = "Namey names";
            TestItem.Role = "jobby";
            TestItem.UpdateCatalogue = true;
            //add to test list
            TestList.Add(TestItem);
            //assign the data to the property
            staff.StaffList = TestList;
            //test to see that theyre the same
            Assert.AreEqual(staff.StaffList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            clsStaffCollection staff = new clsStaffCollection();
            Int32 SomeCount = 0;
            staff.Count = SomeCount;
            Assert.AreEqual(staff.Count, SomeCount);
        }
        [TestMethod]
        public void ThisAddressPropertyOK()
        {
            clsStaffCollection staff = new clsStaffCollection();
            ClsStaff TestStaff = new ClsStaff();
            TestStaff.Active = true;
            TestStaff.StaffNo = "21";
            TestStaff.StaffWage = "200";
            TestStaff.StartDate = DateTime.Now.Date;
            TestStaff.Department = "some dept";
            TestStaff.Name = "Namey names";
            TestStaff.Role = "jobby";
            TestStaff.UpdateCatalogue = true;

            staff.ThisStaff = TestStaff;
            Assert.AreEqual(staff.ThisStaff, TestStaff);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection staff = new clsStaffCollection();
            List<ClsStaff> TestList = new List<ClsStaff>();
            ClsStaff TestItem = new ClsStaff();
            TestItem.Active = true;
            TestItem.StaffNo = "21";
            TestItem.StaffWage = "200";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.Department = "some dept";
            TestItem.Name = "Namey names";
            TestItem.Role = "jobby";
            TestItem.UpdateCatalogue = true;
            //add to list
            TestList(TestItem);
            //assign to property
            staff.StaffList = TestList;
            Assert.AreEqual(staff.Count, TestList.Count);
        }
    }
    [TestClass]
    public class tstStaff
    {
        //good test data
        //some data to pass to the method
        string StaffNo = "21";
        string staffWage = "200";
        string staffRole = "P and C";
        string staffDepartment = "Managment";
        string StartDate = "11/01/2001";
        

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            ClsStaff staff = new ClsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNoMinLessOne()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string StaffNo = "";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNoMin()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string StaffNo = "a";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNoMinPlusOne()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string StaffNo = "aa";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNoMaxLessOne()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string StaffNo = "aaa";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNoMax()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string StaffNo = "aaaa";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNoMid()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string StaffNo = "aaaaa";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNoMaxPlusOne()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string StaffNo = "aaaaaa";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNoExtremeMax()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string StaffNo = "";
            StaffNo = StaffNo.PadRight(500, 'a');
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string StartDate = TestDate.ToString();
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string StartDate = TestDate.ToString();
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string StartDate = TestDate.ToString();
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string StartDate = TestDate.ToString();
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string StartDate = TestDate.ToString();
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string StartDate = "this is not a date!!";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DepartmentMinLessOne()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string staffDepartment = "";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DepartmentMin()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string staffDepartment = "a";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DepartmentMinPlusOne()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string staffDepartment = "aa";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DepartmentMaxLessOne()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string staffDepartment = "aaa";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DepartmentMax()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string staffDepartment = "aaaaa";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DepartmentMaxPlusOne()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string staffDepartment = "aaaaaa";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DepartmentMid()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string staffDepartment = "aaaa";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoleMinLessOne()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string staffRole = "";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoleMin()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string staffRole = "a";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoleMinPlusOne()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string staffRole = "aa";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoleMaxLessOne()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string staffRole = "";
            staffRole = staffRole.PadRight(49, 'a');
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoleMax()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string staffRole = "";
            staffRole = staffRole.PadRight(50, 'a');
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoleMaxPlusOne()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string staffRole = "";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoleMid()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string staffRole = "";
            staffRole = staffRole.PadRight(25, 'a');
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void WageMinLessOne()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string staffWage = "";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        public void WageMin()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string staffWage = "a";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreEqual(Error, "");
        }
        public void WagetMinPlusOne()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string staffWage = "aa";
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreEqual(Error, "");
        }
        public void WagetMaxLessOne()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string staffWage = "";
            staffWage = staffWage.PadRight(49, 'a');
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreEqual(Error, "");
        }
        public void WagetMax()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string staffWage = "";
            staffWage = staffWage.PadRight(50, 'a');
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreEqual(Error, "");
        }
        public void WageMaxPlusOne()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string staffWage = "";
            staffWage = staffWage.PadRight(51, 'a');
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }
        public void WageMid()
        {
            ClsStaff staff = new ClsStaff();
            String Error = "";
            string staffWage = "";
            staffWage = staffWage.PadRight(25, 'a');
            Error = staff.Valid(StaffNo, staffWage, staffRole, staffDepartment, StartDate);
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void InstanceOK()
        {
            ClsStaff staff = new ClsStaff();

            Assert.IsNotNull(staff);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            ClsStaff staff = new ClsStaff();

            Boolean TestData = true;

            staff.Active = TestData;

            Assert.AreEqual(staff.Active, TestData);
        }
        [TestMethod]
        public void StartDatePropertyOK()
        {
            ClsStaff staff = new ClsStaff();

            DateTime TestData = Convert.ToDateTime("11/01/2001");

            staff.StartDate = TestData;

            Assert.AreEqual(staff.StartDate, TestData);
        }
        [TestMethod]
        public void NamePropertyOK()
        {
            ClsStaff staff = new ClsStaff();

            string TestData = "Alfie Nickson";

            staff.Name = TestData;

            Assert.AreEqual(staff.Name, TestData);

        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            ClsStaff staff = new ClsStaff();

            string TestData = "Managment";

            staff.Department = TestData;

            Assert.AreEqual(staff.Department, TestData);
        }

        [TestMethod]

        public void WagePropertyOK()
        {
            ClsStaff staff = new ClsStaff();

            String TestData = "100";

            staff.StaffWage = TestData;

            Assert.AreEqual(staff.StaffWage, TestData);

        }

        [TestMethod]
        public void UpdateCataloguePropertyOK()
        {
            ClsStaff staff = new ClsStaff();

            Boolean TestData = true;

            staff.UpdateCatalogue = TestData;

            Assert.AreEqual(staff.UpdateCatalogue, TestData);

        }
        [TestMethod]
        public void RolePropertyOK()
        {
            ClsStaff staff = new ClsStaff();

            string TestData = "P and C";

            staff.Role = TestData;

            Assert.AreEqual(staff.Role, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            ClsStaff staff = new ClsStaff();
            Boolean Found = false;
            Int32 StaffNo = 21;
            Found = staff.Find(StaffNo);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestNameNotFound()
        {
            ClsStaff staff = new ClsStaff();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StaffNo = 21;

            Found = staff.Find(StaffNo);

            if (staff.Name != "Alfie Nickson")
            {
                OK = false;
            }

            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void TestWageNotFound()
        {
            ClsStaff staff = new ClsStaff();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StaffNo = 21;

            Found = staff.Find(StaffNo);

            if (staff.StaffWage != "200")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDepartmentNotFound()
        {
            ClsStaff staff = new ClsStaff();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StaffNo = 21;

            Found = staff.Find(StaffNo);

            if (staff.Department != "Managment")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestRoleNotFound()
        {
            ClsStaff staff = new ClsStaff();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StaffNo = 21;

            Found = staff.Find(StaffNo);

            if (staff.Role != "P and C")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestStartDateNotFound()
        {
            ClsStaff staff = new ClsStaff();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StaffNo = 21;

            Found = staff.Find(StaffNo);

            if (staff.StartDate != Convert.ToDateTime("11/01/2001"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestUpdateCatalogue()
        {
            ClsStaff staff = new ClsStaff();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StaffNo = 21;

            Found = staff.Find(StaffNo);

            if (staff.UpdateCatalogue != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            ClsStaff staff = new ClsStaff();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StaffNo = 21;

            Found = staff.Find(StaffNo);

            if (staff.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestStaffIdFound()
        {
            ClsStaff staff = new ClsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffNo = 21;
            Found = staff.Find(StaffNo);
            if (staff.StaffNo != "21")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}

