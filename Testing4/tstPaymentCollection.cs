using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ClassLibrary
{
    namespace Testing4
    {
        [TestClass]

        public class tstPaymentCollection
        {
            [TestMethod]
            public void TestMethod1()
            {

            }


            public void InstanceOK()
            {
                //create an instance of the class we want to create

                clsPaymentCollection AllPayments = new clsPaymentCollection();
                //test to see that it exists
                Assert.IsNotNull(AllPayments);
            }

            public void PaymentListOK()
            {
                clsPaymentCollection AllPayments = new clsPaymentCollection();
                //create some test data to assign to the property
                //in this case the data needs to be a list of objects
                List<clsPayment> TestList = new List<clsPayment>();
                //add an item to the list
                //create the item of test data
                clsPayment TestItem = new clsPayment();
                //set it's properties
                TestItem.Active = true;
                TestItem.NameAdded = "some name";
                TestItem.CardAdded = "some card number";
                TestItem.CVVAdded = "CVV No.";
                TestItem.IDAdded = "ID No.";
                TestItem.AmountAdded = "some amount";
                //add the item to the test list
                TestList.Add(TestItem);
                //assign the data to the property
                AllPayments.PaymentList = TestList;
                //test to see that two values are the same
                Assert.AreEqual(AllPayments.PaymentList, TestList);
            }

            public void CountPropertyOK()
            {
                clsPaymentCollection AllPayments = new clsPaymentCollection();
                //create some test data to assign to the property
                Int32 SomeCount = 2;
                //assign the data to the property
                AllPayments.Count = SomeCount;
                Assert.AreEqual(AllPayments.Count, SomeCount);

            }


            [TestMethod]

            public void ThisPaymentPropertyOK()
            {
                clsPaymentCollection AllPayments = new clsPaymentCollection();
                //create some test data to assign to the property
                clsPayment TestPayment = new clsPayment();
                //set the properties of the test object
                TestPayment.Active = true;
                TestPayment.NameAdded = "some name";
                TestPayment.CardAdded = "some card number";
                TestPayment.CVVAdded = "CVV No.";
                TestPayment.IDAdded = "ID No.";
                TestPayment.AmountAdded = "some amount";
                //assign the data to the property
                AllPayments.ThisPayment = TestPayment;
                //test to see that the two values are the same
                Assert.AreEqual(AllPayments.ThisPayment, TestPayment);
            }

            [TestMethod]
            public void ListAndCountOK()
            {
                clsPaymentCollection AllPayments = new clsPaymentCollection();

                List<clsPayment> TestList = new List<clsPayment>();

                clsPayment TestItem = new clsPayment();
                //set its properties
                TestItem.Active = true;
                TestItem.NameAdded = "some name";
                TestItem.CardAdded = "some card number";
                TestItem.CVVAdded = "CVV No.";
                TestItem.IDAdded = "ID No.";
                TestItem.AmountAdded = "some amount";
                //add the item to the test list
                TestList.Add(TestItem);
                //assign the data to the property
                AllPayments.PaymentList = TestList;
                //test to see that the two values are the same
                Assert.AreEqual(AllPayments.Count, TestList.Count);
            }

            public void TwoRecordsPresent()
            {
                clsPaymentCollection AllPayments = new clsPaymentCollection();

                Assert.AreEqual(AllPayments.Count, 2);
            }

            


            
            }
        }
    }


