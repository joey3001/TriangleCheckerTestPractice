using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void TriangleCheck_IsTriangleEqualateral_True()
    {
      Triangle testTriangle = new Triangle(2,2,2);
      Assert.AreEqual("Equilateral", testTriangle.TriangleCheck());
    }

    [TestMethod]
    public void TriangleCheck_IsTriangleIsoscoles_True()
    {
      Triangle testTriangle = new Triangle(1,2,2);
      Assert.AreEqual("Isoscoles", testTriangle.TriangleCheck());
    }
  }
}