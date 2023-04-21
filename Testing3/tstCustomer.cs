﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingCustomer_Framework
{
    [TestClass]
    public class tstCustomer
    {
        string CustomerName = "Antonio Moore";
        string AddressLine1 = "1 Abbey Road";
        string PostCode = "LE67 2JU";
        string EmailAddress = "antmo297@gmail.com";
        string AccountCreationDate = DateTime.Now.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
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

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 14;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the address no
            
            
            if (ACustomer.CustomerID != 14)
            {
                OK = false;
            }
            
            //test to see that the result is correct
            Assert.IsNotNull(OK);
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
            Assert.IsNotNull(OK);
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
            Assert.IsNotNull(OK);
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
            Assert.IsNotNull(OK);
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
            Assert.IsNotNull(OK);
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
            Assert.IsNotNull(OK);
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
            if (ACustomer.AccountCreationDate != Convert.ToDateTime("14/02/2023"))
            {
                OK = false;
            }
            //test to see if correct result is given
            Assert.IsNotNull(OK);
        }

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string CustomerName = ""; 
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void CustomerNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string CustomerName = "A"; 
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string CustomerName = "An"; 
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(24, 'a');
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(25, 'a');
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(26, 'a');
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(13, 'a');
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(500, 'a');
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreationDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string AccountCreationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreationDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string AccountCreationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreationDateMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string AccountCreationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreationDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string AccountCreationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);//test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreationDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string AccountCreationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);//test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountCreationDateInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            string AccountCreationDate = "not a date!";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);//test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PostCode = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "a";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aa";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PostCode = "aaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine1MinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string AddressLine1 = "";
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine1Min()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string AddressLine1 = "1";
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine1MinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string AddressLine1 = "1a";
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine1MaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string AddressLine1 = "";
            AddressLine1 = AddressLine1.PadRight(39, 'a');
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine1Max()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string AddressLine1 = "";
            AddressLine1 = AddressLine1.PadRight(40, 'a');
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine1MaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string AddressLine1 = "";
            AddressLine1 = AddressLine1.PadRight(41, 'a');
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine1Mid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string AddressLine1 = "";
            AddressLine1 = AddressLine1.PadRight(20, 'a');
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLine1ExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string AddressLine1 = "";
            AddressLine1 = AddressLine1.PadRight(400, 'a');
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string EmailAddress = "";
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string EmailAddress = "a";
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string EmailAddress = "aa";
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(253, 'a');
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(254, 'a');
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(255, 'a');
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(127, 'a');
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(2540, 'a');
            //invoke method
            Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }



    }
}

      
        








