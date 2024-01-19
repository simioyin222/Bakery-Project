using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void BreadCost_CalculateSingleLoafCost_Int()
        {
            Assert.AreEqual(5, Bread.BreadCost(1));
        }
    }

}