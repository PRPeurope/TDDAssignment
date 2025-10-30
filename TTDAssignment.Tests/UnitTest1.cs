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
    
    [Fact]
    public void Test_Input_Is_Not_Negative_Value()
    {
      var romanNumeral = new RomanNumeral("-1");
      Assert.False(romanNumeral.ValidateInput());
    }

    [Fact]
    public void Test_Input_Is_Not_Greater_Then_3000()
    {
      var romanNumeral = new RomanNumeral("3001");
      Assert.False(romanNumeral.ValidateInput());
    }
}
