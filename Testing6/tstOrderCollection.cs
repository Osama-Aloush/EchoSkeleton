using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ClassLibrary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing6
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void InstanceOK()
        {
            //Creating an instance of the class
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Tests to see if it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //Creating an instance of the class
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Test List data
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an item into the list
            clsOrder TestItem = new clsOrder();
            //Set properties
            TestItem.Delivery_Status = true;
            TestItem.Delivery_Address = "Some Address";
            TestItem.Item_Quantity = 3;
            TestItem.Order_Description = "Some Description";
            TestItem.Order_Date = DateTime.Now.Date;
            TestItem.Order_ID = 1;
            //Add Test data to list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }


        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //Creating an instance of the class
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Creating test data
            clsOrder TestOrder = new clsOrder();
            //Set Properties
            TestOrder.Delivery_Status = true;
            TestOrder.Delivery_Address = "Some Address";
            TestOrder.Item_Quantity = 3;
            TestOrder.Order_Description = "Some Description";
            TestOrder.Order_Date = DateTime.Now.Date;
            TestOrder.Order_ID = 1;
            //Assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //Testing to see if the 2 values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK() {
            //Creating an instance of the class
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Test List data
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an item into the list
            clsOrder TestItem = new clsOrder();
            //Set properties
            TestItem.Delivery_Status = true;
            TestItem.Delivery_Address = "Some Address";
            TestItem.Item_Quantity = 3;
            TestItem.Order_Description = "Some Description";
            TestItem.Order_Date = DateTime.Now.Date;
            TestItem.Order_ID = 1;
            //Add Test data to list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllOrders.OrderList = TestList;
            //Testing to see if the 2 values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        //Add, Update, Delete Method Tests

        [TestMethod]
        public void AddMethodOK() {
            //Creating an instance of the class
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Test data
            clsOrder TestItem = new clsOrder();
            //Varible to store primary key
            Int32 PrimaryKey = 0;
            //Set properties
            TestItem.Order_ID = 1;
            TestItem.Delivery_Status = true;
            TestItem.Delivery_Address = "Some Address";
            TestItem.Item_Quantity = 3;
            TestItem.Order_Description = "Some Description";
            TestItem.Order_Date = DateTime.Now.Date;
            
            //Set ThisOrder to test item
            AllOrders.ThisOrder = TestItem;
            //Add the record
            PrimaryKey = AllOrders.Add();
            //Set the primary key of the data
            TestItem.Order_ID = PrimaryKey;
            //Find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //Test to see the values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK() {
            //Creating an instance of the collections class
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Create test data
            clsOrder TestItem = new clsOrder();
            //Primary key variable
            Int32 PrimaryKey = 0;
            //Set the properties
            TestItem.Order_ID = 1;
            TestItem.Order_Description = "Some Description";
            TestItem.Order_Date = DateTime.Now.Date;
            TestItem.Delivery_Status = true;
            TestItem.Item_Quantity = 3;
            TestItem.Delivery_Address = "Some Address";

            //Set ThisOrder to testdata
            AllOrders.ThisOrder = TestItem;
            //Add record
            PrimaryKey = AllOrders.Add();
            //Set the primary key of the test data
            TestItem.Order_ID = PrimaryKey;
            //Find record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //Delete record
            AllOrders.Delete();
            //Now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //Check if the record wasn't found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK() {
            //Creating an instance of the class
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Test data
            clsOrder TestItem = new clsOrder();
            //Primary key varible
            Int32 PrimaryKey;
            //Set properties
            TestItem.Delivery_Status = true;
            TestItem.Delivery_Address = "Some Address";
            TestItem.Item_Quantity = 3;
            TestItem.Order_Description = "Some Description";
            TestItem.Order_Date = DateTime.Now.Date;
            //Set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //Add the record
            PrimaryKey = AllOrders.Add();
            //Set the primary key to test data
            TestItem.Order_ID = PrimaryKey;
            //Modify test
            TestItem.Delivery_Status = false;
            TestItem.Delivery_Address = "Some Updated Address";
            TestItem.Item_Quantity = 5;
            TestItem.Order_Description = "Some Updated Description";
            TestItem.Order_Date = DateTime.Now.Date;
            //Set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //Update the record
            AllOrders.Update();
            //Find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //Test to see ThisOrder matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }

        [TestMethod]
        public void ReportByStreetTypeMethodOK() {
            //Creating an instance of the class
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Creating an intance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //Apply a blank string to record all the records
            FilteredOrders.ReportByStreetType("");
            //Test to see if the two values are equal
            Assert.AreEqual(AllOrders.Count,FilteredOrders.Count);

        }

        [TestMethod]
        public void ReportByStreetTypeNoneFound() {
            //Create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //Apply street type that doesn't exist
            FilteredOrders.ReportByStreetType("xxxxx");
            //Test to see if there are no records
            Assert.AreEqual(0,FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByStreetTypeFound()
        {
            //Create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //Varible for outcomes
            Boolean OK = true;
            FilteredOrders.ReportByStreetType("yyyyy");

            //Check that the correct number of records are found
            if (FilteredOrders.Count == 2) {
                if (FilteredOrders.OrderList[0].Order_ID != 3) {
                    OK = false;
                }

                if (FilteredOrders.OrderList[1].Order_ID != 4)
                {
                    OK = false;
                }

                else {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }
        }





    }
}


