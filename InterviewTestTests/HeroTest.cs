using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewTestTests
{
    [TestClass]
    public class HeroTest
    {
        [TestMethod]
        public void Delete(int ID)
        {
            Assert.IsNotNull(ID);
            //Below is just fun, ignore
            Assert.AreEqual(0, ID);

        }
        [TestMethod]

        public void Get(int ID)
        {
            Assert.IsNotNull(ID);
            Assert.AreEqual(0, ID);

        }

        [TestMethod]

        public void evolve(int ID, string action)
        {
            Assert.IsNotNull(ID);
            Assert.AreEqual(0, ID);
            Assert.AreEqual(action, action);

        }
    }
}
