using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastriesTests
  {
    [TestMethod]
    public void PastriesTotal_CalculatePriceWithDiscount_int()
    {
      //Arrange
      Pastries TestPastries = new Pastries();
      
      //Act
      TestPastries.Count = 6;

      //Assert
      Assert.AreEqual(10, TestPastries.PastriesTotal);
    }
    // [TestMethod]
    // public void PastriesTotal_CalculatePriceWithoutDiscount_int()
    // {
    //   //Arrange
    //   Pastries TestPastries = new Pastries();
      
    //   //Act
    //   TestPastries.Count = 1;

    //   //Assert
    //   Assert.AreEqual(5, TestPastries.PastriesTotal);
    // }
  }
}