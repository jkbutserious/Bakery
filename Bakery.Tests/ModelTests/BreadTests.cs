using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadTotal_CalculatePriceWithDiscount_int()
    {
      //Arrange
      Bread TestBread = new Bread();
      
      //Act
      TestBread.Count = 6;

      //Assert
      Assert.AreEqual(20, TestBread.BreadTotal);
    }
    [TestMethod]
    public void BreadTotal_CalculatePriceWithoutDiscount_int()
    {
      //Arrange
      Bread TestBread = new Bread();
      
      //Act
      TestBread.Count = 1;

      //Assert
      Assert.AreEqual(5, TestBread.BreadTotal);
    }
  }
}