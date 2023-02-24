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
  }
}