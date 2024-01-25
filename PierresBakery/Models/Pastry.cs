namespace PierresBakery.Models
{
    public class Pastry
    {
        public int Quantity { get; set; }

        public Pastry(int quantity)
        {
            Quantity = quantity;
        }

        public int CalculateTotalCost()
        {
            int pricePerPastry = 2;
            int numberOfFreePastries = Quantity / 4;
            return (Quantity - numberOfFreePastries) * pricePerPastry;
        }
    }
}
 

