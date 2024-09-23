using homework_2;

namespace Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Throws<Exception>(Computations.MethodThatThrows);
    }
}