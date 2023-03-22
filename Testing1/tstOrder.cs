using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {

        [TestMethod]
        public void InstanceOK()
        {
            //creates an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test too see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
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
            Assert.IsTrue(OK);
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
            Assert.IsTrue(OK);

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
            Assert.IsTrue(OK);
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
            if (AnOrder.UnitPrice != 1)
            {
                OK = false;
            }
        }
    }


}


