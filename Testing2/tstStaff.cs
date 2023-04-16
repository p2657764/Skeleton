using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
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

            int TestData = 100;

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

            if (staff.StaffWage != 200)
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
            if (staff.StaffNo != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
            


            


        
    }
}

