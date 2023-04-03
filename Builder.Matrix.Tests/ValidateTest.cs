namespace Builder.Matrix.Tests;

[TestClass]
public class ValidateTest
{
    [TestMethod]
    public void IsInteger0Test()
    {
        var input = "0";

        var expected = true;

        var actual = Validate.IsInteger(input);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void IsIntegerTextTest()
    {
        var input = "q";

        var expected = false;

        var actual = Validate.IsInteger(input);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void IsIntegerSymbolTest()
    {
        var input = "@";

        var expected = false;

        var actual = Validate.IsInteger(input);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void IsIntegerNumberTest()
    {
        var input = "789";

        var expected = true;

        var actual = Validate.IsInteger(input);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void IsPositive0Test()
    {
        var input = "0";

        var expected = false;

        var actual = Validate.IsPositive(input);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void IsPositiveNegativeTest()
    {
        var input = "-1";

        var expected = false;

        var actual = Validate.IsPositive(input);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void IsPositiveTextTest()
    {
        var input = "qwe";

        var expected = false;

        var actual = Validate.IsPositive(input);
        
        Assert.AreEqual(expected, actual);
    }
}