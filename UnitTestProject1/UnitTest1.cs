using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int result = OOP_lab_2_23_4.Program.Multiplication(array);
            Assert.AreEqual(result, 40320);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int result = OOP_lab_2_23_4.Program.SumNegative(array);
            Assert.AreEqual(result, 0);
        }
    }
}
