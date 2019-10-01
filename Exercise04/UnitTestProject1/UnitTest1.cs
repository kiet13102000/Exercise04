using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise04;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsIsODD()
        {
            bool result3 = Program.IsOdd(3);
            Assert.AreEqual(true, result3);

            bool result4 = Program.IsOdd(4);
            Assert.AreEqual(false, result4);
        }
        public void TestIsPrime()
        {
            bool test7 = Program.IsPrime(7);
            Assert.AreEqual(true, test7);

            bool testam3 = Program.IsPrime(-3);
            Assert.AreEqual(false, testam3);
        }
        public void TestISSquare()
        {
            int test5 = Program.Square(5);
            Assert.AreEqual(true, test5);

            int test6 = Program.Square(6);
            Assert.AreEqual(false, test6);


        }
    }
}
