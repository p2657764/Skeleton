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
        public void ListAndCountPropertyOK()
        {
            //create an instance of a class
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data 
            List<clsOrder> TestList = new List<clsOrder>();
            //add item and create data item in list
            clsOrder TestItem = new clsOrder();
            //set properties
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
            Assert.AreEqual(AllOrder.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an intance of class to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.OrderID = 1;
            TestItem.ProductQuantity = 10;
            TestItem.UnitPrice = (int)109.99;
            TestItem.OrderVerification = true;
            TestItem.OrderPlacedDate = DateTime.Now.Date;
            TestItem.ShippingDate = DateTime.Now.Date.AddDays(5);
            //set ThisOrder to test data
            AllOrder.ThisOrder = TestItem;
            //add record
            PrimaryKey = AllOrder.Add();
            //set the primary key of test data
            TestItem.OrderID = PrimaryKey;
            //find record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see if two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we wanto to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.ProductQuantity = 10;
            TestItem.UnitPrice = (int)109.99;
            TestItem.OrderVerification = true;
            TestItem.OrderPlacedDate = DateTime.Now.Date;
            TestItem.ShippingDate = DateTime.Now.Date.AddDays(5);
            //set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.ProductQuantity = 5;
            TestItem.UnitPrice = (int)5.59;
            TestItem.OrderVerification = false;
            TestItem.OrderPlacedDate = DateTime.Now.Date;
            TestItem.ShippingDate = DateTime.Now.Date.AddDays(10);
            //set the record based on the new test data
            AllOrder.ThisOrder = TestItem;
            //update the record
            AllOrder.Update();
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see ThisOrder matches the test data
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary keyt
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.ProductQuantity = 10;
            TestItem.UnitPrice = (int)109.99;
            TestItem.OrderVerification = true;
            TestItem.OrderPlacedDate = DateTime.Now.Date;
            TestItem.ShippingDate = DateTime.Now.Date.AddDays(5);
            //set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the rectord
            AllOrder.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrder.Delete();
            //now find the record
            Boolean Found = AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByOrderPlacedDateMethodOK()
        {
            //create an instance of the class containig unfiltered results
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a blank string (should return all records)
            FilteredOrders.ReportByOrderPlacedDate("");
            //test to see that the two values are thes same
            Assert.AreEqual(AllOrder.Count, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByOrderPlacedDateNoneFound()
        {
            //create an instnce of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a order placed date that doesnt exist
            FilteredOrders.ReportByOrderPlacedDate("32/13/2022");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByOrderPlacedDateFound()
        {
            //create an instance of the filktered data
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a order placed date that does exist
            FilteredOrder.ReportByOrderPlacedDate("01/01/2001");
            //check that the correct number of records are found
            if (FilteredOrder.Count == 2)
            {
                //check that the first record id is 44
                if (FilteredOrder.OrderList[0].OrderID != 44)
                {
                    OK = false;
                }
                //check that the first record is ID 49
                if(FilteredOrder.OrderList[1].OrderID != 49)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
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
            AnOrder.UnitPrice = TestData;
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
            Int32 OrderID = 18;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 18;
            //invoke the method
            Found = AnOrder.Find(OrderID);
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
            Int32 OrderID = 18;
            //invoke the method
            Found = AnOrder.Find(OrderID);
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
            Int32 OrderID = 18;
            //invoke the method
            Found = AnOrder.Find(OrderID);
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
            Int32 OrderID = 18;
            //invoke the metho
            Found = AnOrder.Find(OrderID);
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
            Int32 OrderID = 18;
            //invoke the method
            Found = AnOrder.Find(OrderID);
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
            Int32 OrderID = 18;
            //invoke the method
            Found = AnOrder.Find(OrderID);
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
            Int32 OrderID = 18;
            //invoke the method
            Found = AnOrder.Find(OrderID);
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



//CREATE PROCEDURE [dbo].sproc_tlbOrder_FilterByOrderPlacedDate
//--this stored procedure uses the like function to find order placed date that matches the value
//--stored in the parameter orderplaceddate
//--the stored procedure doesnt return a value


//	--declare the parameter as date
//	@OrderPlacedDate date
//AS
//	--select all fields from any records that have a orderplaced date like this orderplaceddate
//	select * from tblOrder where OrderPlacedDate like @OrderPlacedDate+'%';
