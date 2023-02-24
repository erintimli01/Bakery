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
      Bread BreadInstance = new Bread();
      Assert.AreEqual(typeof(Bread), BreadInstance.GetType());
    }
  }
}