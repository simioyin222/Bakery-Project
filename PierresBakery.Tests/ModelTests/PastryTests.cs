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
    }
}