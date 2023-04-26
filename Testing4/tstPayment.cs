using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstPayment
    {
        string NameAdded = "Osama Aloush";
        string CardAdded = "1234";
        string CVVAdded = "123";
        string IDAdded = "123456789";
        string AmountAdded = "100";

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

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void NameAddedMin()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NameAdded = "a"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void NameAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NameAdded = "aa"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void NameAddedMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NameAdded = "aaaaa"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void NameAddedMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NameAdded = "aaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void NameAddedMid()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NameAdded = "aaa"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void NameAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NameAdded = ""; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void NameAddedMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NameAdded = "aaaaaaa"; //this should fail
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void NameAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NameAdded = ""; //this should trigger an error
            NameAdded = NameAdded.PadRight(500, 'a');
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void CardAddedMin()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CardAdded = "a"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void CardAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CardAdded = "aa"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void CardAddedMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CardAdded = "aaaaa"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void CardAddedMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CardAdded = "aaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void CardAddedMid()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CardAdded = "aaa"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void CardAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CardAdded = ""; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void CardeAddedMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CardAdded = "aaaaaaa"; //this should fail
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void CardAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string NameAdded = ""; //this should trigger an error
            CardAdded = CardAdded.PadRight(500, 'a');
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void CVVAddedMin()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CVVAdded = "a"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void CVVAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CVVAdded = "aa"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void CVVAddedMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CVVAdded = "aaaaa"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void CVVAddedMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CVVAdded = "aaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void CVVAddedMid()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CVVAdded = "aaa"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void CVVAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CVVAdded = ""; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void CVVAddedMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CVVAdded = "aaaaaaa"; //this should fail
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void CVVAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CVVAdded = ""; //this should trigger an error
            CVVAdded = CVVAdded.PadRight(500, 'a');
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void IDAddedMin()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string IDAdded = "a"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void IDAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string IDAdded = "aa"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void IDAddedMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string IDAdded = "aaaaa"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void IDAddedMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string IDAdded = "aaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void IDAddedMid()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string IDAdded = "aaa"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void IDAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string IDAdded = ""; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void IDAddedMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string IDAdded = "aaaaaaa"; //this should fail
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void IDAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string IDAdded = ""; //this should trigger an error
            IDAdded = IDAdded.PadRight(500, 'a');
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void AmountAddedMin()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AmountAdded = "a"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void AmountAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AmountAdded = "aa"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void AmountAddedMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AmountAdded = "aaaaa"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void AmountAddedMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AmountAdded = "aaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void AmountAddedMid()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AmountAdded = "aaa"; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void AmountAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AmountAdded = ""; //this should trigger an error
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void AmountAddedMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AmountAdded = "aaaaaaa"; //this should fail
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }

        public void AmountAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AmountAdded = ""; //this should trigger an error
            AmountAdded = AmountAdded.PadRight(500, 'a');
            //invoke the method
            Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
            //test to see that reult is correct
            Assert.AreEqual(Error, "");
        }






    }
}
