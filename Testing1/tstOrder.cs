﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
