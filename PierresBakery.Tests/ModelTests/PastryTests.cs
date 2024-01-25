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

        [TestMethod]
        public void CalculateTotalCost_ReturnsCorrectTotalCostForPastryOrder_Int()
        {
            Pastry pastryOrder = new Pastry(4);
            Assert.AreEqual(6, pastryOrder.CalculateTotalCost());
        }

        [TestMethod]
        public void CalculateTotalCost_ReturnsZeroForZeroPastries_Int()
        {
            Pastry pastryOrder = new Pastry(0);
            Assert.AreEqual(0, pastryOrder.CalculateTotalCost());
        }
    }
}