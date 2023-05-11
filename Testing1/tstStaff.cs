using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace tstStaff
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void TestMethod1()
        {

            clsPayment AnPayment = new clsPayment();

            Assert.IsNotNull(AnPayment);

        }
    

    }
}
