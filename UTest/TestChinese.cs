using NUnit.Framework;
using TDD;

namespace UTest;

public class TestChinese
{
    private IRace person;
    
    [SetUp]
    public void Setup()
    {
        person = new Chinese();
    }

    [Test]
    public void TestHairColor()
    {
        Assert.Equals("black", person.HairColor);
    }
    
    [Test]
    public void TestEyeColor()
    {
        Assert.Equals("brown", person.EyeColor);
    }
    
    [Test]
    public void TestGreet()
    {
        Assert.Equals("你好", person.Greet());
    }
}