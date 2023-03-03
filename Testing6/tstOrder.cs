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
            tstOrder sampleOrder = new tstOrder();
            //Checking if the object exist
            Assert.IsNotNull(sampleOrder);
        }

    }

 
}
