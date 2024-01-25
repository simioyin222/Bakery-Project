using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void BreadConstructor_CreatesInstanceOfBread_Bread()
        {
            Bread breadOrder = new Bread(2);
            Assert.AreEqual(typeof(Bread), breadOrder.GetType());
        }

        [TestMethod]
        public void CalculateTotalCost_ReturnsCorrectTotalCostForBreadOrder_Int()
        {
            Bread breadOrder = new Bread(3);
            Assert.AreEqual(10, breadOrder.CalculateTotalCost());
        }

        [TestMethod]
        public void CalculateTotalCost_ReturnsZeroForZeroLoaves_Int()
        {
            Bread breadOrder = new Bread(0);
            Assert.AreEqual(0, breadOrder.CalculateTotalCost());
        }
    }
}