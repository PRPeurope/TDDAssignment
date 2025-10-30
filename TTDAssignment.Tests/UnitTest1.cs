namespace TTDAssignment.Tests;

public class UnitTest1
{
    [Fact]
    public void Test()
    {
      Assert.True(true);
    }

    [Fact]
    public void Test_Input_Is_String()
    {
      var romanNumeral = new RomanNumeral("TEST");
      Assert.False(romanNumeral.ValidateInput());
      Assert.IsNotType<int>(romanNumeral.ValidateInput());
    }

}
