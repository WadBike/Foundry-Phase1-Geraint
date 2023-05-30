using WhoseCoatIsThatJacket;

namespace Unit_Test;

public class UnitTest1
{
    [Fact]
    public void Test_GetHealth()
    {
        Bryn bryn = new Bryn();

        string result = bryn.GetHealth(100);
    }
}
