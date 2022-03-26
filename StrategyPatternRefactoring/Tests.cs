using NUnit.Framework;
using StrategyPatternRefactoring;

[TestFixture]
public class Tests
{
    private RefactoringSwitchToStrategy _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new RefactoringSwitchToStrategy();
    }
    
    [Test]
    public void TestThatRectangleAreaIsCalculatedCorrectly()
    {
        var expectedArea = 100.0;

        var result = _sut.CalculateArea(Shape.Rectangle, 10.0, 10.0, 0, 0);
        
        Assert.AreEqual(expectedArea, result);
    }
    
    [Test]
    public void TestThatCircleAreaIsCalculatedCorrectly()
    {
        var expectedArea = 314.15926535897933;

        var result = _sut.CalculateArea(Shape.Circle, 0.0, 0.0, 10.0, 0);
        
        Assert.AreEqual(expectedArea, result);
    }
    
    [Test]
    public void TestThatTriangleAreaIsCalculatedCorrectly()
    {
        var expectedArea = 43.301270189221931;

        var result = _sut.CalculateArea(Shape.Triangle, 0.0, 0.0, 0, 10.0);
        
        Assert.AreEqual(expectedArea, result);
    }
}