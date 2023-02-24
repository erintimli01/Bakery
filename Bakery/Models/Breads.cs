namespace Bakery.Models
{
  public class Bread
  {
    private const int InitialCharge = 5;
    public Bread(int quantity)
    {
      Quantity = quantity;
    }
    public int Quantity { get; set; }
  
    public int Total()
    {
      int initialCharge = Quantity * InitialCharge;
      int sale = GetSale();
      return initialCharge - sale;
    }
    private int GetSale()
    {
      int threeLoaves = Quantity / 3;
      int sale = threeLoaves * InitialCharge;
      return sale;
    }
  }
}

  