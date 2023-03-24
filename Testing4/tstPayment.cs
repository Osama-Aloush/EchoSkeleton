using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstPayment
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsPayment AnPayment = new clsPayment();

            Assert.IsNotNull(AnPayment);
        }

        [TestMethod]

        public void ActivePropertyOK()
        {
            clsPayment AnPayment = new clsPayment();

            Boolean TestData = true;

            AnPayment.Active = TestData;

            Assert.AreEqual(AnPayment.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsPayment AnPayment = new clsPayment();

            DateTime TestData = DateTime.Now.Date;

            AnPayment.DateAdded = TestData;

            Assert.AreEqual(AnPayment.DateAdded, TestData);
        }

        [TestMethod]
        public void HolderNamePropertyOK()
        {
            clsPayment AnPayment = new clsPayment();

            string TestData = "Holder Name";

            AnPayment.NameAdded = TestData;

            Assert.AreEqual(AnPayment.NameAdded, TestData);
        }

        [TestMethod]
        public void CardNumberPropertyOK()
        {
            clsPayment AnPayment = new clsPayment();

            string TestData = "Card Number";

            AnPayment.CardAdded = TestData;

            Assert.AreEqual(AnPayment.CardAdded, TestData);
        }

        [TestMethod]
        public void CVVPropertyOK()
        {
            clsPayment AnPayment = new clsPayment();

            string TestData = "###";

            AnPayment.CVVAdded = TestData;

            Assert.AreEqual(AnPayment.CVVAdded, TestData);
        }

        [TestMethod]
        public void IDPropertyOK()
        {
            clsPayment AnPayment = new clsPayment();

            string TestData = "ID Number";

            AnPayment.IDAdded = TestData;

            Assert.AreEqual(AnPayment.IDAdded, TestData);
        }

        [TestMethod]
        public void AmountPropertyOK()
        {
            clsPayment AnPayment = new clsPayment();

            string TestData = "Payment Amount";

            AnPayment.AmountAdded = TestData;

            Assert.AreEqual(AnPayment.AmountAdded, TestData);
        }
    }
}
