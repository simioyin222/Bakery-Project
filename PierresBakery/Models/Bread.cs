namespace PierresBakery.Models
{
    public class Bread
    {
        public static int BreadCost(int quantity)
        {
            int pricePerLoaf = 5;
            int numberOfFreeLoaves = quantity / 3;
            int totalCost = (quantity - numberOfFreeLoaves) * pricePerLoaf;
            return totalCost;
        }
    }
}