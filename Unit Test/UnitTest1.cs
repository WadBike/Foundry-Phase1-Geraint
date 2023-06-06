using WhoseCoatIsThatJacket;

namespace Unit_Test;

public class UnitTest1
{
    Knife knife = new Knife("Small", 1, "An unused butter knife found on the table. Great for buttering your toast!", 1);

    [Fact]

    public bool containsBlood()
    {
        Assert.True(knife.containsBlood());
        return true;
    }
}