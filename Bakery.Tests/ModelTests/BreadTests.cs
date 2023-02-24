using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests

{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void CreateInstance_CreateInstanceOfBread_Bread()
    {
      Bread breadInstance = new Bread(0);
      Assert.AreEqual(typeof(Bread), breadInstance.GetType());
    }

    [TestMethod]
    public void BreadQuantity_SetBreadQuantity_Quantity()
    {
      Bread breadInstance = new Bread(2);
      Assert.AreEqual(2, breadInstance.Quantity);
    }

    [TestMethod]
    public void GetTotal_PriceForOne_Price()
    {
      Bread breadInstance = new Bread(1);
      Assert.AreEqual(5, breadInstance.Total());
    }

    [TestMethod]
    public void GetTotal_PriceFor2_Price()
    {
      Bread breadInstance = new Bread(2);
      Assert.AreEqual(10, breadInstance.Total());
    }

    [TestMethod]
    public void GetTotal_PriceFor3_Price()
    {
      Bread breadInstance = new Bread(3);
      Assert.AreEqual(10, breadInstance.Total());
    }

    [TestMethod]
    public void GetTotal_PriceFor7_Price()
    {
      Bread breadInstance = new Bread(7);
      Assert.AreEqual(25, breadInstance.Total());
    }

  }
}