using Sqr;

namespace SqrTest1;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void SCircleTest()
    {
        double radius = 5;
        double expected = radius * radius * Math.PI;

        Circle c = new Circle(5);
        var actual = c.S();

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void STriagleTest()
    {
        double a = 3;
        double b = 4;
        double c = 5;

        double expected = 6;

        Triangle f = new Triangle(a, b, c);
        var res = f.SCalc();

        Assert.AreEqual(expected, res);
    }

    [TestMethod]
    public void GetIsRectangularTriangleTest()
    {
        double a = 3;
        double b = 4;
        double c = 5;
        
        Triangle t = new Triangle(a, b, c);
        var res = t.GetIsRectangularTriangle();

        Assert.AreEqual(true, res);
    }
}