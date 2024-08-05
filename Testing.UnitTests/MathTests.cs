using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using Math = UnitTesting.Fundamentals.Math;

namespace UnitTestProject;

[TestFixture]
public class MathTests
{
    private Math _math;

    [SetUp]
    public void Setup()
    {
        _math = new Math();
    }
    
    
    [Test]
    [TestCase(10, 5, 10)]
    [TestCase(5, 10, 10)]
    [TestCase(10, 10, 10)]
    public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
    {
        //Act
        var result = _math.Max(a, b);
        //Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
    
    
    [Test]
    [Ignore("Because is too simple and I am lazy")]
    public void Add_WhenCalled_ReturnTheSumOfArguments()
    {
        //Arrange
        const int a = 5;
        const int b = 5;
        
        //Act
        var result = _math.Add(a, b);
        
        //Assert
        Assert.That(result, Is.EqualTo(10));
    }
}