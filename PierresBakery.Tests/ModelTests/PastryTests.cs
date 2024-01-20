using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void PastryCost_CalculateSinglePastryCost_Int()
        {
            Assert.AreEqual(2, Pastry.PastryCost(1));
        }

        [TestMethod]
        public void PastryCost_CalculateMultiplePastriesCostWithDeal_Int()
        {
            Assert.AreEqual(6, Pastry.PastryCost(4)); // Buy 3, get 1 free deal
        }
    }
}