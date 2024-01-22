using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class BreadTests
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void BreadCost_CalculateSingleLoafCost_Int()
        {
            Assert.AreEqual(5, Bread.BreadCost(1));
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void BreadCost_CalculateMultipleLoavesCostWithDeal_Int()
        {
            Assert.AreEqual(10, Bread.BreadCost(3));
        }
    }
}