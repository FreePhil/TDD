using NUnit.Framework;
using TDD;

namespace UTest;

[TestFixture]
public class TestAmerica
{
    private IRace person;
    
    [SetUp]
    public void Setup()
    {
        person = new American();
    }

    [Test]
    public void TestHairColor()
    {
        Assert.Equals("golden", person.HairColor);
    }
    
    [Test]
    public void TestEyeColor()
    {
        Assert.Equals("green", person.EyeColor);
    }
    
    [Test]
    public void TestGreet()
    {
        Assert.Equals("howdy", person.Greet());
    }    
}