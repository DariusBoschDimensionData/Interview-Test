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
    }
}
