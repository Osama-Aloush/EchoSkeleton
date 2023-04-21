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
        // Test Find Methods
        [TestMethod]
        public void FindMethodOK() {

            //Creating an instance of the class
            clsOrder AnOrder = new clsOrder();
            //Creating boolean value for the validation results
            Boolean Found = false;
            //Test Data
            Int32 itemNo = 3;
            //Invoking the method
            Found = AnOrder.Find(itemNo);
            //Testing to see if the result is true
            Assert.IsTrue(Found);
        
        }

        [TestMethod]
        public void TestNumberOfItemsFound() {
            //Creating an instance of the class
            clsOrder AnOrder = new clsOrder();
            //Creating boolean value for the validation results
            Boolean Found = false;
            Boolean OK = true;
            Int32 testData = 8;
            //Invoking the method
            Found = AnOrder.Find(testData);

            //Checking for the testData
            if (AnOrder.Item_Quantity != 8) {
                OK = false;
            }

            Assert.IsTrue(OK);


        }


        [TestMethod]
        public void TestOrderDateFound() {

            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;

            Int32 testData = 8;

            Found = AnOrder.Find(testData);

            if (AnOrder.Order_Date != Convert.ToDateTime("24/02/2004")) {
                OK = false;
            }

            Assert.IsTrue(OK);
        
        }

        [TestMethod]
        public void TestDeliveryAddressFound() {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;

            Int32 testData = 8;

            Found = AnOrder.Find(testData);

            if (AnOrder.Delivery_Address != "Test Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderIDFound() {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;

            Int32 testData = 8;

            Found = AnOrder.Find(testData);

            if (AnOrder.Order_ID != "O-1")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDescriptionFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;

            Int32 testData = 8;

            Found = AnOrder.Find(testData);

            if (AnOrder.Order_Description != "Cereal")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryStatusFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;

            Int32 testData = 8;

            Found = AnOrder.Find(testData);

            if (AnOrder.Delivery_Status != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderTotalFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;

            Int32 testData = 8;

            Found = AnOrder.Find(testData);

            if (AnOrder.Order_Total != 25)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


    }



}


}
