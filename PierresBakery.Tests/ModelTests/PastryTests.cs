using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class PastryTests
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void PastryCost_CalculateSinglePastryCost_Int()
        {
            Assert.AreEqual(2, Pastry.PastryCost(1));
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void PastryCost_CalculateMultiplePastriesCostWithDeal_Int()
        {
            Assert.AreEqual(6, Pastry.PastryCost(4));
        }
    }
}