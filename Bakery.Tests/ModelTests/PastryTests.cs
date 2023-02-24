using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
[TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void CreateInstance_CreateInstanceOfPastry_Pastry()
    {
      Pastry pastryInstance = new Pastry(0);
      Assert.AreEqual(typeof(Pastry), pastryInstance.GetType());
    }

    [TestMethod]
    public void PastryQuantity_SetPastryQuantity_Quantity()
    {
      Pastry pastryInstance = new Pastry(2);
      Assert.AreEqual(2, pastryInstance.Quantity);
    }

    [TestMethod]
    public void GetTotal_PriceForOne_Price()
    {
      Pastry pastryInstance = new Pastry(1);
      Assert.AreEqual(2, pastryInstance.Total());
    }

    [TestMethod]
    public void GetTotal_PriceFor2_Price()
    {
      Pastry pastryInstance = new Pastry(2);
      Assert.AreEqual(4, pastryInstance.Total());
    }

    [TestMethod]
    public void GetTotal_PriceFor4_Price()
    {
      Pastry pastryInstance = new Pastry(4);
      Assert.AreEqual(6, pastryInstance.Total());
    }


  }
}