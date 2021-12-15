using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevOpsInterview
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ThisTestWillPass()
        {
            Assert.AreEqual(1, 1);
        }
        
        [TestMethod]
        public void ThisTestWillFail()
        {
            Assert.AreEqual(1, 2);
        }

    }
}
