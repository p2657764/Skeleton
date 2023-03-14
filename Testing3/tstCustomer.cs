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
        public void CustomerIDOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            Int32 TestData = 1;
            ACustomer.CustomerID = TestData;
            Assert.AreEqual(ACustomer.CustomerID, TestData);
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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerID = 14;
            Found = ACustomer.Find(CustomerID);
            Assert.IsTrue(Found);
        }

        /**
        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //store result of search
            Boolean Found = false;
            //variable to record if data is OK
            Boolean OK = true;
            //test data
            Int32 CustomerID = 14;
            //invokes find method
            Found = ACustomer.Find(CustomerID);
            //check customer ID
            if (ACustomer.CustomerID != 14)
            {
                OK = false;
            }
            //test to see if correct result is given
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //store result of search
            Boolean Found = false;
            //variable to record if data is OK
            Boolean OK = true;
            //test data
            Int32 CustomerID = 14;
            //invokes find method
            Found = ACustomer.Find(CustomerID);
            //check customer name
            if (ACustomer.CustomerName != "Test Name")
            {
                OK = false;
            }
            //test to see if correct result is given
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressLine1Found()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //store result of search
            Boolean Found = false;
            //variable to record if data is OK
            Boolean OK = true;
            //test data
            Int32 CustomerID = 14;
            //invokes find method
            Found = ACustomer.Find(CustomerID);
            //check address line
            if (ACustomer.AddressLine1 != "TestAddressLine")
            {
                OK = false;
            }
            //test to see if correct result is given
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //store result of search
            Boolean Found = false;
            //variable to record if data is OK
            Boolean OK = true;
            //test data
            Int32 CustomerID = 14;
            //invokes find method
            Found = ACustomer.Find(CustomerID);
            //check post code
            if (ACustomer.PostCode != "TestPostCode")
            {
                OK = false;
            }
            //test to see if correct result is given
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailAddressFound()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //store result of search
            Boolean Found = false;
            //variable to record if data is OK
            Boolean OK = true;
            //test data
            Int32 CustomerID = 14;
            //invokes find method
            Found = ACustomer.Find(CustomerID);
            //check email address
            if (ACustomer.EmailAddress != "TestEmailAddress")
            {
                OK = false;
            }
            //test to see if correct result is given
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailVerificationFound()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //store result of search
            Boolean Found = false;
            //variable to record if data is OK
            Boolean OK = true;
            //test data
            Int32 CustomerID = 14;
            //invokes find method
            Found = ACustomer.Find(CustomerID);
            //check email verification
            if (ACustomer.EmailVerification != true)
            {
                OK = false;
            }
            //test to see if correct result is given
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAccountCreationDateFound()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //store result of search
            Boolean Found = false;
            //variable to record if data is OK
            Boolean OK = true;
            //test data
            Int32 CustomerID = 14;
            //invokes find method
            Found = ACustomer.Find(CustomerID);
            //check account creation date
            if (ACustomer.AccountCreationDate != Convert.ToDateTime("15/02/2023"))
            {
                OK = false;
            }
            //test to see if correct result is given
            Assert.IsTrue(OK);
        }
    }
}
        **/
        

        