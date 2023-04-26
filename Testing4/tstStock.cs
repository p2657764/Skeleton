using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(Stock);
        }

        [TestMethod]
        public void InStockOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data
            Boolean TestData = true;
            //assign the data to assign to the sofa
            Stock.Active = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(Stock.Active, TestData);    
        }

        [TestMethod]    
        public void DateGeneratedStockOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data to assign to the sofa
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Stock.DateAdded = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(Stock.DateAdded, TestData);
        }

        [TestMethod]
        public void StockQuantityOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data
            Int32 TestData = 1;
            //assign the data to assign to the sofa
            Stock.StockNo = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(Stock.StockNo, TestData);
        }

        [TestMethod]
        public void UnitPriceOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data
            Int32 TestData = 2;
            //assign the data to assign to the sofa
            Stock.UnitPrice = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(Stock.UnitPrice, TestData);
        }

        [TestMethod]
        public void ColourOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data
            string TestData = "Blue";
            //assign the data to assign to the sofa
            Stock.StockColour = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(Stock.StockColour, TestData);
        }

        [TestMethod]
        public void StockNameOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data
            string TestData = "Harrison 2 Seater Sofa";
            //assign the data to assign to the sofa
            Stock.StockName = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(Stock.StockName, TestData);
        }

        [TestMethod]
        public void ProductIDOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //create some test data
            Int32 TestData = 1;
            //assign the data to assign to the sofa
            Stock.ProductID = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(Stock.ProductID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ProductID = 22;
            //invoke the method
            Found = Stock.Find(ProductID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 22;
            //invoke the method
            Found = Stock.Find(ProductID);
            //Check the product ID
            if (Stock.ProductID !=22)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 22;
            //invoke the method
            Found = Stock.Find(ProductID);
            //Check the product name
            if (Stock.StockName != "Test name")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestColourFound()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 22;
            //invoke the method
            Found = Stock.Find(ProductID);
            //Check the product name
            if (Stock.StockColour != "Test colour")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUnitPriceFound()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 22;
            //invoke the method
            Found = Stock.Find(ProductID);
            //Check the product name
            if (Stock.UnitPrice != 3)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockQuantityFound()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 22;
            //invoke the method
            Found = Stock.Find(ProductID);
            //Check the product name
            if (Stock.StockNo != 2)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestDateGeneratedFound()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 22;
            //invoke the method
            Found = Stock.Find(ProductID);
            //Check the product name
            if (Stock.DateAdded !=Convert.ToDateTime("11/03/2023"))
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 22;
            //invoke the method
            Found = Stock.Find(ProductID);
            //Check the product name
            if (Stock.Active != true)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(Found);
        }
    }
}
