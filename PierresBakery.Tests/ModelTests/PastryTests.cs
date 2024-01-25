using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
        {
            Pastry pastryOrder = new Pastry(2);
            Assert.AreEqual(typeof(Pastry), pastryOrder.GetType());
        }

    }
}