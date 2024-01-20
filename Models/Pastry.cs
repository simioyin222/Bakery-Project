namespace PierresBakery.Models
{
    public class Pastry
    {
        public static int PastryCost(int quantity)
        {
            int pricePerPastry = 2;
            int numberOfFreePastries = quantity / 4;
            int totalCost = (quantity - numberOfFreePastries) * pricePerPastry;
            return totalCost;
        }
    }
}