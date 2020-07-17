using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadTotal_AddOneLoafOfBreadToOrder_1()
    {
      //Arrange
      Bread TestBread = new Bread();
      
      //Act
      TestBread.Loaves = 6;

      //Assert
      Assert.AreEqual(20, TestBread.BreadTotal);
    }
  }
}