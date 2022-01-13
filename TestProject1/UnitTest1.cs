using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFLoat()
        {
            float a = .43F;
            float b = .43F;
            Assert.IsTrue(a == b);
        }
    }
}
