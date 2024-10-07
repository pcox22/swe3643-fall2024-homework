using homework_2;

namespace Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void TestCOMPUTE_STANDARD_DEVIATION()
    {
        int[] sampleValuesList = new int[5] {9, 6, 8, 5, 7};
        Assert.That(() => Computations.COMPUTE_STANDARD_DEVIATION(sampleValuesList, true), Throws.Nothing);
    }
}