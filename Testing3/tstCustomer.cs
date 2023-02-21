using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        private string aPostCode = "LE67 YJQ";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void ValidOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string TestData = aPostCode;
            Error = ACustomer.Valid(aPostCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "John Appleton";
            ACustomer.CustomerName = TestData;
            Assert.AreEqual(ACustomer.CustomerName, TestData);
        }

        [TestMethod]
        public void AddressLine1OK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "10 The Close";
            ACustomer.AddressLine1 = TestData;
            Assert.AreEqual(ACustomer.AddressLine1, TestData);
        }

        [TestMethod]
        public void PostCodeOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "LE5 ABC";
            ACustomer.PostCode = TestData;
            Assert.AreEqual(ACustomer.PostCode, TestData);
        }

        [TestMethod]
        public void EmailAddressOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "jonnyappleton1962@gmail.com";
            ACustomer.EmailAddress = TestData;
            Assert.AreEqual(ACustomer.EmailAddress, TestData);
        }

        [TestMethod]
        public void EmailVerificationOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = true;
            ACustomer.EmailVerification = TestData;
            Assert.AreEqual(ACustomer.EmailVerification, TestData);
        }

        [TestMethod]
        public void AccountCreationDateOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.AccountCreationDate = TestData;
            Assert.AreEqual(ACustomer.AccountCreationDate, TestData);
        }
    }
}


        