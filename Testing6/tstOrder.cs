using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing6
{
    [TestClass]
    class tstOrder
    {
        public bool Active { get; private set; }
        public string OrderDescription { get; private set; }

        [TestMethod]
        public void TestMethod1()
        {
            //Creating an instance of the sample class
            clsOrder sampleOrder = new clsOrder();
            //Checking if the object exist
            Assert.IsNotNull(sampleOrder);
        }


        [TestMethod]
        public void OrderDescriptionPropertyOk()
        {
            //Creating instance of the class
            clsOrder sampleOrder = new clsOrder();

            String TestData = "Carrots";

            sampleOrder.OrderDescription = TestData;

            Assert.AreEqual(sampleOrder.OrderDescription,TestData);

        }

        [TestMethod]
        public void OrderTotalPropertyOk()
        {
            clsOrder sampleOrder = new clsOrder();

            int TestData = 1;

            sampleOrder.OrderTotal = TestData;

            Assert.AreEqual(sampleOrder.OrderTotal, TestData);
        
        }

        [TestMethod]
        public void HasDiscountPropertyOk()
        {
            clsOrder sampleOrder = new clsOrder();

            bool TestData = true;

            sampleOrder.HasDiscount = TestData;

            Assert.AreEqual(sampleOrder.HasDiscount, TestData);

        }

        [TestMethod]
        public void DiscountAmountPropertyOk()
        {
            clsOrder sampleOrder = new clsOrder();

            int TestData = 1;

            sampleOrder.DiscountAmount = TestData;

            Assert.AreEqual(sampleOrder.DiscountAmount, TestData);

        }




    }


}
