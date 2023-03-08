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
        public void OrderQuantityOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.OrderVerification = TestData;
            Assert.AreEqual(AnOrder.OrderVerification, TestData);
        }





    }

}


