using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrder);
        }
        [TestMethod]
        public void OrderListOK()
        {
            //create instance of class
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data e.g. objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add item and create data item in list
            clsOrder TestItem = new clsOrder();
            //set properties
            TestItem.Active = true;
            TestItem.OrderID = 1;
            TestItem.ProductQuantity = 10;
            TestItem.UnitPrice = (int)109.99;
            TestItem.OrderVerification = true;
            TestItem.OrderPlacedDate = DateTime.Now.Date;
            TestItem.ShippingDate = DateTime.Now.Date.AddDays(5);
            //add item to test list
            TestList.Add(TestItem);
            //assign data to the property
            AllOrder.OrderList = TestList;
            //test to see if values are the same
            Assert.AreEqual(AllOrder.OrderList, TestList);

        }
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.Active = true;
            TestOrder.OrderID = 1;
            TestOrder.ProductQuantity = 10;
            TestOrder.UnitPrice = (int)109.99;
            TestOrder.OrderVerification = true;
            TestOrder.OrderPlacedDate = DateTime.Now.Date;
            TestOrder.ShippingDate = DateTime.Now.Date.AddDays(5);
            //assign the data to the property
            AllOrder.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void CountProperty()
        {
            //create an instance of the class we want to creat
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllOrder.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.Count, SomeCount);
        }
    }
    [TestClass]
    public class tstOrder
    {
        string OrderPlacedDate = DateTime.Now.ToString();
        string ShippingDate = DateTime.Now.AddDays(5).ToString();
        bool OrderVerification = true;
        int ProductQuantity = 1;
        double UnitPrice = 5.99;

        [TestMethod]
        public void InstanceOK()
        {
            //creates an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test too see that it exists
            Assert.IsNotNull(AnOrder);
        }
        public void ActivePropertyOK()
        {
            //creates an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Active = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.Active, TestData);
        }

        [TestMethod]
        public void OrderPlacedDateOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderPlacedDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderPlacedDate, TestData);
        }

        [TestMethod]
        public void OrderVerificationOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.OrderVerification = TestData;
            Assert.AreEqual(AnOrder.OrderVerification, TestData);
        }
        [TestMethod]
        public void ProductQuantityOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //assign some test data to assign to the property
            int TestData = 20;
            //assign the data to the property
            AnOrder.ProductQuantity = TestData;
            //test to see if the values are the same
            Assert.AreEqual(AnOrder.ProductQuantity, TestData);
        }

        [TestMethod]
        public void UnitPriceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //assign some test data to assign to the property
            double TestData = 9.99;
            //assign the data to the property
            AnOrder.UnitPrice = (int)TestData;
            //test to see if the values are the same
            Assert.AreEqual(AnOrder.UnitPrice, TestData);
        }

        [TestMethod]
        public void ShippingDateOK()
        {
            //crete an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //assign some test data to assign to the property
            DateTime TestData = DateTime.Now.AddDays(5);
            //assign the data to the property
            AnOrder.ShippingDate = TestData;
            //test to see if the values are the same
            Assert.AreEqual(AnOrder.ShippingDate, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderNo = 18;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 18;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.OrderID != 18)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsNotNull(OK);
        }
        [TestMethod]
        
        public void TestOrderPlacedDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 18;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.OrderPlacedDate != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsNotNull(OK);

        }
        [TestMethod]       
        public void TestShippingDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is ok(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 18;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.ShippingDate != Convert.ToDateTime("23/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsNotNull(OK);

        }
        [TestMethod]
        public void TestOrderVerificationFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 18;
            //invoke the metho
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.OrderVerification != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsNotNull(OK);
        }

        [TestMethod]
        public void TestProductQuantityFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean varaible to record if the data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 18;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.ProductQuantity != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsNotNull(OK);
        }

        [TestMethod]
        public void TestUnitPriceFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 18;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.UnitPrice != 5.99)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsNotNull(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 18;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsNotNull(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //strin variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(OrderPlacedDate, Convert.ToString(ProductQuantity), Convert.ToString(UnitPrice), ShippingDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductQuanityMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            int ProductQuantity = 1; //this should be ok

            //invoke the method
            Error = AnOrder.Valid(OrderPlacedDate, Convert.ToString(ProductQuantity), Convert.ToString(UnitPrice), ShippingDate); ;
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductQuanityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            int ProductQuantity = 2; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderPlacedDate, Convert.ToString(ProductQuantity), Convert.ToString(UnitPrice), ShippingDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderPlacedDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a varibale to store the test date data
            DateTime TestDate;
            //set the data to todays data
            TestDate = DateTime.Now.Date;
            //change the data to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to string variable
            string OrderPlacedDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderPlacedDate, Convert.ToString(ProductQuantity), Convert.ToString(UnitPrice), ShippingDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderPlacedDateMinLessThanOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a varibale to store the test date data
            DateTime TestDate;
            //set the data to todays data
            TestDate = DateTime.Now.Date;
            //change the data to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to string variable
            string OrderPlacedDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderPlacedDate, Convert.ToString(ProductQuantity), Convert.ToString(UnitPrice), ShippingDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderPlacedDateMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a varibale to store the test date data
            DateTime TestDate;
            //set the data to todays data
            TestDate = DateTime.Now.Date;
            //convert the date variable to string variable
            string OrderPlacedDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderPlacedDate, Convert.ToString(ProductQuantity), Convert.ToString(UnitPrice), ShippingDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderPlacedDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a varibale to store the test date data
            DateTime TestDate;
            //set the data to todays data
            TestDate = DateTime.Now.Date;
            //change the data to whatever the date is plus one day
            TestDate = TestDate.AddDays(+1);
            //convert the date variable to string variable
            string OrderPlacedDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderPlacedDate, Convert.ToString(ProductQuantity), Convert.ToString(UnitPrice), ShippingDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderPlacedDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a varibale to store the test date data
            DateTime TestDate;
            //set the data to todays data
            TestDate = DateTime.Now.Date;
            //change the data to whatever the date is more 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to string variable
            string OrderPlacedDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderPlacedDate, Convert.ToString(ProductQuantity), Convert.ToString(UnitPrice), ShippingDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void OrderPlacedDateInvalidDate()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string OrderPlacedDate = "This is not a date!";
            //invoke the method
            Error = AnOrder.Valid(OrderPlacedDate, Convert.ToString(ProductQuantity), Convert.ToString(UnitPrice), ShippingDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}



