using WhoseCoatIsThatJacket;

namespace Unit_Test1;

[TestClass]
public class UnitTest1
{
    Player player = new Player();

    [TestMethod]
    public void TestHealthModifier()
    {
        Assert.AreEqual(80, player.modifyHealth(-20));
        Assert.AreEqual(0, player.modifyHealth(-100));
        Assert.AreEqual(30, player.modifyHealth(-70));
    }
}
