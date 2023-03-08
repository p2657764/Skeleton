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
    }
}

