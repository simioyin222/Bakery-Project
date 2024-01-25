namespace PierresBakery.Models
{
    public class Bread
    {
        public int Quantity { get; set; }

        public Bread(int quantity)
        {
            Quantity = quantity;
        }

        public int CalculateTotalCost()
        {
            int pricePerLoaf = 5;
            int numberOfFreeLoaves = Quantity / 3;
            return (Quantity - numberOfFreeLoaves) * pricePerLoaf;
        }
    }
}