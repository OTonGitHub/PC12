namespace Averages.Tests;


[TestClass]
public class WhenCalculatingAverages
/*
    "A class for each scenario in which you want to test a particular class, 
    with one method for each of the things that should be true about your code in that scenario."
*/
{
    [TestMethod]
    public void SingleInputShouldProduceSameValueAsResult()
    {
        string[] inputs = { "1" };
        double result = AverageCalculator.ArthemeticMean(inputs);
        Assert.AreEqual(1.0, result, 1E-14);
    }

    [TestMethod]
    public void MultipleInputsShouldProduceAverageAsResult()
    {
        string[] inputs = { "1", "2", "3" };
        double result = AverageCalculator.ArthemeticMean(inputs);
        Assert.AreEqual(2.0, result, 1E-14);
    }
}