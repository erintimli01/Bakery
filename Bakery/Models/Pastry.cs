namespace Bakery.Models
{
  public class Pastry
  {
    private const int InitialCharge = 2;
    public Pastry(int quantity)
    {
      Quantity = quantity;
    }
    public int Quantity { get; set; }

    public int Total()
    {
      int initialCharge = Quantity * InitialCharge;
      int sale = GetSale();
      return initialCharge;
    }
    private int GetSale()
    {
      int qFourPastries = Quantity / 4;
      int sale = qFourPastries * InitialCharge;
      return sale;
    }
  }
}