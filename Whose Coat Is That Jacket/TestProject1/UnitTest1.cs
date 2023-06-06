using WhoseCoatIsThatJacket;

namespace Unit_Test1;

[TestClass]
public class UnitTest1
{
    InflatableLeek leek = new InflatableLeek("Small", 1, "It's an inflateable leek... The kind of thing you see Welsh people holding during the Rugby for some inexplicable reason.", 10);

    [TestMethod]
    public void TestContainsBlood()
    {
        Assert.IsFalse(leek.containsBlood());
    }
}