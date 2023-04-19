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


        [TestMethod]
        public void TestMethod1()
        {
            //Creating an instance of the sample class
            clsOrder sampleOrder = new clsOrder();
            //Checking if the object exist
            Assert.IsNotNull(sampleOrder);
        }

        [TestMethod]
        public void Order_IDPropertyOK()
        {
            clsOrder sampleOrder = new clsOrder();
            String TestData = "AS21";
            sampleOrder.Order_ID = TestData;
            Assert.AreEqual(sampleOrder.Order_ID, TestData);
        }


        [TestMethod]
        public void Order_DescriptionPropertyOK()
        {
            //Creating instance of the class
            clsOrder sampleOrder = new clsOrder();
            String TestData = "Carrots";
            sampleOrder.Order_Description = TestData;
            Assert.AreEqual(sampleOrder.Order_Description, TestData);

        }

        [TestMethod]
        public void Order_TotalPropertyOk()
        {
            clsOrder sampleOrder = new clsOrder();
            int TestData = 1;
            sampleOrder.Order_Total = TestData;
            Assert.AreEqual(sampleOrder.Order_Total, TestData);

        }

        [TestMethod]
        public void Item_QuantityPropertyOk()
        {
            clsOrder sampleOrder = new clsOrder();
            int TestData = 1;
            sampleOrder.Item_Quantity = TestData;
            Assert.AreEqual(sampleOrder.Item_Quantity, TestData);

        }

        [TestMethod]
        public void Delivery_StatusPropertyOK()
        {
            clsOrder sampleOrder = new clsOrder();
            Boolean TestData = true;
            sampleOrder.Delivery_Status = TestData;
            Assert.AreEqual(sampleOrder.Delivery_Status, TestData);

        }

        [TestMethod]
        public void Delivery_AddressPropertyOK()
        {
            clsOrder sampleOrder = new clsOrder();
            String TestData = "123 ABC Street";
            sampleOrder.Delivery_Address = TestData;
            Assert.AreEqual(sampleOrder.Delivery_Address, TestData);
        
        }

        [TestMethod]
        public void Order_DatePropertyOK() {
            clsOrder sampleOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            sampleOrder.Order_Date = TestData;
            Assert.AreEqual(sampleOrder.Order_Date, TestData);

        }




    }


}
