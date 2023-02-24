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
      Bread BreadInstance = new Bread(2);
      Assert.AreEqual(2, BreadInstance.Quantity);
    }
  }
}