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
        public void CalculateTotalCost_ReturnsCorrectTotalCostForSinglePastry_Int()
        {
            Pastry pastryOrder = new Pastry(1);
            Assert.AreEqual(2, pastryOrder.CalculateTotalCost());
        }

        [TestMethod]
        public void CalculateTotalCost_ReturnsCorrectTotalCostForFourPastries_Int()
        {
            Pastry pastryOrder = new Pastry(4);
            Assert.AreEqual(6, pastryOrder.CalculateTotalCost());
        }
    }
}