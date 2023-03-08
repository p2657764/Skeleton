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
            clsStaff staff = new clsStaff();

            Assert.IsNotNull(staff);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsStaff staff = new clsStaff();

            Boolean TestData = true;

            staff.Active = TestData;

            Assert.AreEqual(staff.Active, TestData);
           }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsStaff staff = new clsStaff();

            DateTime TestData = DateTime.Now.Date;

            staff.DateAdded = TestData;

            Assert.AreEqual(staff.DateAdded, TestData);
        }
        [TestMethod]
        public void NamePropertyOK()
        {
            clsStaff staff = new clsStaff();

            string TestData = "Dale Brannigan";

            staff.Name = TestData;

            Assert.AreEqual(staff.Name, TestData);

        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsStaff staff = new clsStaff();

            string TestData = "Managment";

            staff.Department = TestData;

            Assert.AreEqual(staff.Department, TestData);
        }
        
        }
    }

