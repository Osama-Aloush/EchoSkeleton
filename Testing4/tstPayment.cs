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

            string TestData = "Expiry Date";

            AnPayment.DateTime = TestData;

            Assert.AreEqual(AnPayment.DateTime, TestData);
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

        [TestMethod]
        public void FindMethodOK()
        {
            clsPayment AnPayment = new clsPayment();

            Boolean Found = false;

            Boolean OK = true;

            string NameAdded = "Osama AlOush";

            Found = AnPayment.Find(NameAdded);

            if (AnPayment.NameAdded != "Osama AlOush")
            {
                OK = false;
            }

            Assert.IsTrue(Found);
        }

        public void FindCardNo()
        {
            clsPayment AnPayment = new clsPayment();

            Boolean Found = false;

            Boolean OK = true;

            string CardAdded = "1234";

            Found = AnPayment.Find(CardAdded);

            if (AnPayment.CardAdded != "1234")
            {
                OK = false;
            }

            Assert.IsTrue(Found);
        }

        public void FindCVVNo()
        {
            clsPayment AnPayment = new clsPayment();

            Boolean Found = false;

            Boolean OK = true;

            string CVVAdded = "1234";

            Found = AnPayment.Find(CVVAdded);

            if (AnPayment.CardAdded != "123")
            {
                OK = false;
            }

            Assert.IsTrue(Found);
        }

        public void FindIDNo()
        {
            clsPayment AnPayment = new clsPayment();

            Boolean Found = false;

            Boolean OK = true;

            string IDAdded = "1234";

            Found = AnPayment.Find(IDAdded);

            if (AnPayment.IDAdded != "123456789")
            {
                OK = false;
            }

            Assert.IsTrue(Found);
        }

        public void FindAmount()
        {
            clsPayment AnPayment = new clsPayment();

            Boolean Found = false;

            Boolean OK = true;

            string AmountAdded = "1234";

            Found = AnPayment.Find(AmountAdded);

            if (AnPayment.AmountAdded != "100")
            {
                OK = false;
            }

            Assert.IsTrue(Found);
        }




    }
}
