using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace tstOrder
{
    [TestClass]
    public class tstOrder
    {

        //Good test data
        String orderDescVal = "";
        String addressVal = "";
        Int32 itemNoVal = 3;
        String orderDateVal = DateTime.Now.Date.ToString();


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
            Int32 TestData = 1;
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
            Int32 TestData = 1;
            //Invoking the method
            Found = AnOrder.Find(TestData);
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
            Int32 testData = 1;
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
            Int32 testData = 1;

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

            Int32 testData = 1;

            Found = AnOrder.Find(testData);

            if (AnOrder.Delivery_Address != "18 Test Street")
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

            Int32 testData = 1;

            Found = AnOrder.Find(testData); //Find the record in the database

            if (AnOrder.Order_ID != 1) {
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

            Int32 testData = 1;

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

            Int32 testData = 1;

            Found = AnOrder.Find(testData);

            if (AnOrder.Delivery_Status != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void ValidMethodOK() {
            clsOrder anOrder = new clsOrder();

            //String to store the error message
            String Error = "";

            Error = anOrder.Valid(orderDescVal,addressVal,itemNoVal,orderDateVal);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMinLessOne() {
            //Creating an Instace of the class
            clsOrder anOrder = new clsOrder();
            //variable to store the error
            String Error = "";
            //Test data
            String orderDescVal = "";

            Error = anOrder.Valid(orderDescVal, addressVal, itemNoVal, orderDateVal);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMin() {
            //Creating an Instace of the class
            clsOrder anOrder = new clsOrder();
            //variable to store the error
            String Error = "";
            //Test data
            String orderDescVal = "a";

            Error = anOrder.Valid(orderDescVal, addressVal, itemNoVal, orderDateVal);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderDescriptionMinPlusOne()
        {
            //Creating an Instace of the class
            clsOrder anOrder = new clsOrder();
            //variable to store the error
            String Error = "";
            //Test data
            String orderDescVal = "aa";

            Error = anOrder.Valid(orderDescVal, addressVal, itemNoVal, orderDateVal);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderDescriptionMaxLessOne()
        {
            //Creating an Instace of the class
            clsOrder anOrder = new clsOrder();
            //variable to store the error
            String Error = "";
            //Test data
            String orderDescVal = "aa";

            Error = anOrder.Valid(orderDescVal, addressVal, itemNoVal, orderDateVal);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderDescriptionMax()
        {
            //Creating an Instace of the class
            clsOrder anOrder = new clsOrder();
            //variable to store the error
            String Error = "";
            //Test data
            String orderDescVal = "aaaaaaaaaaaaaaaaaaaaa";

            Error = anOrder.Valid(orderDescVal, addressVal, itemNoVal, orderDateVal);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderDescriptionMid()
        {
            //Creating an Instace of the class
            clsOrder anOrder = new clsOrder();
            //variable to store the error
            String Error = "";
            //Test data
            String orderDescVal = "aaaa";

            Error = anOrder.Valid(orderDescVal, addressVal, itemNoVal, orderDateVal);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderDescriptionExtremeMax()
        {
            //Creating an Instace of the class
            clsOrder anOrder = new clsOrder();
            //variable to store the error
            String Error = "";
            //Test data
            String orderDescVal = "";
            orderDescVal = orderDescVal.PadRight(21, 'a');

            Error = anOrder.Valid(orderDescVal, addressVal, itemNoVal, orderDateVal);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateExtremeMin() {
            //Creating an Instace of the class
            clsOrder anOrder = new clsOrder();
            //variable to store the error
            String Error = "";

            //Test Data
            DateTime TestDate;

            //Set to today's date
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is 100 years ago
            TestDate = TestDate.AddYears(-100);

            //Convert Date to String
            String orderDateVal = TestDate.ToString();
            //Invoke the method
            Error = anOrder.Valid(orderDescVal, addressVal, itemNoVal, orderDateVal);
            //Tests if the data is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //Creating an Instace of the class
            clsOrder anOrder = new clsOrder();
            //variable to store the error
            String Error = "";

            //Test Data
            DateTime TestDate;

            //Set to today's date
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);

            //Convert Date to String
            String orderDateVal = TestDate.ToString();
            //Invoke the method
            Error = anOrder.Valid(orderDescVal, addressVal, itemNoVal, orderDateVal);
            //Tests if the data is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            //Creating an Instace of the class
            clsOrder anOrder = new clsOrder();
            //variable to store the error
            String Error = "";

            //Test Data
            DateTime TestDate;

            //Set to today's date
            TestDate = DateTime.Now.Date;
            //Convert Date to String
            String orderDateVal = TestDate.ToString();
            //Invoke the method
            Error = anOrder.Valid(orderDescVal, addressVal, itemNoVal, orderDateVal);
            //Tests if the data is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //Creating an Instace of the class
            clsOrder anOrder = new clsOrder();
            //variable to store the error
            String Error = "";

            //Test Data
            DateTime TestDate;

            //Set to today's date
            TestDate = DateTime.Now.Date;
            //Change the date to today's date
            TestDate = DateTime.Now.Date;

            //Add One Day to test data date
            TestDate = TestDate.AddDays(1);

            //Convert Date to String
            String orderDateVal = TestDate.ToString();
            //Invoke the method
            Error = anOrder.Valid(orderDescVal, addressVal, itemNoVal, orderDateVal);
            //Tests if the data is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //Creating an Instace of the class
            clsOrder anOrder = new clsOrder();
            //variable to store the error
            String Error = "";

            //Test Data
            DateTime TestDate;

            //Set to today's date
            TestDate = DateTime.Now.Date;
            //Change the date to today's date
            TestDate = DateTime.Now.Date;

            //Add 100 years to today's date
            TestDate = TestDate.AddYears(100);

            //Convert Date to String
            String orderDateVal = TestDate.ToString();
            //Invoke the method
            Error = anOrder.Valid(orderDescVal, addressVal, itemNoVal, orderDateVal);
            //Tests if the data is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidData() {
            //Creating an Instace of the class
            clsOrder anOrder = new clsOrder();
            //Variable to store error
            String Error = "";
            //Set Order date to the non-date value
            orderDateVal = "This is not a date";
            //Invoke the method
            Error = anOrder.Valid(orderDescVal, addressVal, itemNoVal, orderDateVal);
            //Tests if the data is correct
            Assert.AreNotEqual(Error, "");
        }

        //Address Validation
        [TestMethod]
        public void AddressMinLessOne() {
            //Creating an Instace of the class
            clsOrder anOrder = new clsOrder();
            //Variable to store error
            String Error = ""; 
            //Test data
            String addressVal = ""; //0 characters
            //Invoke the method
            Error = anOrder.Valid(orderDescVal, addressVal, itemNoVal, orderDateVal);
            //Tests if the data is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            //Creating an Instace of the class
            clsOrder anOrder = new clsOrder();
            //Variable to store error
            String Error = "";
            //Test data
            String addressVal = "a"; // 1 character
            //Invoke the method
            Error = anOrder.Valid(orderDescVal, addressVal, itemNoVal, orderDateVal);
            //Tests if the data is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //Creating an Instace of the class
            clsOrder anOrder = new clsOrder();
            //Variable to store error
            String Error = "";
            //Test data
            String addressVal = "aa"; //2 characters
            //Invoke the method
            Error = anOrder.Valid(orderDescVal, addressVal, itemNoVal, orderDateVal);
            //Tests if the data is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //Creating an Instace of the class
            clsOrder anOrder = new clsOrder();
            //Variable to store error
            String Error = "";
            //Test data
            String addressVal = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //39 characters
            //Invoke the method
            Error = anOrder.Valid(orderDescVal, addressVal, itemNoVal, orderDateVal);
            //Tests if the data is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            //Creating an Instace of the class
            clsOrder anOrder = new clsOrder();
            //Variable to store error
            String Error = "";
            //Test data
            String addressVal = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //40 characters
            //Invoke the method
            Error = anOrder.Valid(orderDescVal, addressVal, itemNoVal, orderDateVal);
            //Tests if the data is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //Creating an Instace of the class
            clsOrder anOrder = new clsOrder();
            //Variable to store error
            String Error = "";
            //Test data
            String addressVal = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //41 characters
            //Invoke the method
            Error = anOrder.Valid(orderDescVal, addressVal, itemNoVal, orderDateVal);
            //Tests if the data is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //Creating an Instace of the class
            clsOrder anOrder = new clsOrder();
            //Variable to store error
            String Error = "";
            //Test data
            String addressVal = "aaaaaaaaaaaaaaaaaaaa"; //20 characters
            //Invoke the method
            Error = anOrder.Valid(orderDescVal, addressVal, itemNoVal, orderDateVal);
            //Tests if the data is correct
            Assert.AreNotEqual(Error, "");
        }





    }



}