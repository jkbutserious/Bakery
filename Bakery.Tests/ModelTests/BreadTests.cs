using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    public void AddBreadToOrder_AddOneLoafOfBreadToOrder_1()
    {
      //Arrange
      Order TestOrder = new Order;
      Bread TestBread = new Bread;

      //Act
      TestBread.AddBreadToOrder();
      
      //Assert
      Assert.AreEqual(1, TestOrder.Loaves)
    }
  }
}