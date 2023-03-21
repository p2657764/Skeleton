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

            Int32 TestData = 21 / 12 / 22;

            staff.StartDate = TestData;

            Assert.AreEqual(staff.StartDate, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            ClsStaff staff = new ClsStaff();

            DateTime TestData = DateTime.Now.Date;

            staff.DateAdded = TestData;

            Assert.AreEqual(staff.DateAdded, TestData);
        }
        [TestMethod]
        public void NamePropertyOK()
        {
            ClsStaff staff = new ClsStaff();

            string TestData = "Dale Brannigan";

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

            Int32 TestData = 100;

            staff.Wage = TestData;

            Assert.AreEqual(staff.Wage, TestData);

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

            Boolean TestData = true;

            staff.Role = TestData;

            Assert.AreEqual(staff.Role, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            ClsStaff staffID = new ClsStaff();

            Boolean Found = false;

            Int32 TestData = 21;

            Found = staffID.Find(TestData);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestNameNotFound()
        {
            ClsStaff staff = new ClsStaff();

            Boolean Found = false;

            Boolean OK = true;

            string StaffID = "Alfie";

            Found = staff.Find(StaffID);

            if(staff.Name != "Alfie")
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

            Int32 StaffID = 21;

            Found = staff.Find(StaffID);

            if (staff.Wage != "TestWage")
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

            Int32 StaffID = 21;

            Found = staff.Find(StaffID);

            if (staff.Department != "TestDepartment")
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

            Int32 StaffID = 21;

            Found = staff.Find(StaffID);

            if (staff.Role != "TestRole")
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

            Int32 StaffID = 21;

            Found = staff.Find(StaffID);

            if (staff.StartDate != "TestStartDate")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
            


            


        
    }
}

