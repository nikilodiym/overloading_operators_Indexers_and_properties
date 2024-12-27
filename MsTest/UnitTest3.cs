using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTest
{
    [TestClass]
    internal class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            Task3 card1 = new Task3();
            Task3 card2 = new Task3();
            card1.Balance = 1000;
            card2.Balance = 2000;
            Assert.IsTrue(card1 < card2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Task3 card1 = new Task3();
            Task3 card2 = new Task3();
            card1.Balance = 3000;
            card2.Balance = 4000;
            Assert.IsFalse(card1 < card2);
        }
    }
}
