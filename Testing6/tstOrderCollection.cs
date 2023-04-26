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

        
    }
}
