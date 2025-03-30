using Xunit;

public class CheckerTests
{
    [Fact]
    public void NotOkWhenAnyVitalIsOffRange()
    {
        Assert.False(Checker.VitalsOK(99f, 102, 70));
        Assert.True(Checker.VitalsOK(98.1f, 70, 98));
    }
}