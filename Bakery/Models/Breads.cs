namespace Bakery.Models
{
  public class Bread
  {
    private const int InitalCharge = 5;
    public Bread(int quantity)
    {
      Quantity = quantity;
    }
    public int Quantity { get; set; }
  }
}

  