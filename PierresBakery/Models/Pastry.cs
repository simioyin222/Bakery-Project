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

//  auto implementing proprties in the classes, example how many loaves/ or quanity 1 per class  like get set like price or discount info , want a seprate method to caculate total cost using those methods, should be caculating method for both bread and pastry 
// add read.me 
// caculating total but it needs to be associated with construct like bread. then caculate total rather just all in one thing 

