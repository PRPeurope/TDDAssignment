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

    [Fact]
    public void Test_Input_Is_Not_Zero()
    {
      var romanNumeral = new RomanNumeral("0");
      Assert.False(romanNumeral.ValidateInput());
    }

    [Fact]
    public void Test_Convert_Value_1()
    {
      var romanNumeral = new RomanNumeral("1");
      Assert.Equal("I",romanNumeral.ConvertToRoman());
    }

    [Fact]
    public void Test_Convert_Value_5()
    {
      var romanNumeral = new RomanNumeral("5");
      Assert.Equal("V",romanNumeral.ConvertToRoman());
    }
    
    [Fact]
    public void Test_Convert_Value_3()
    {
      var romanNumeral = new RomanNumeral("3");
      Assert.Equal("III",romanNumeral.ConvertToRoman());
    }
    
    [Fact]
    public void Test_Convert_Value_4()
    {
      var romanNumeral = new RomanNumeral("4");
      Assert.Equal("IV",romanNumeral.ConvertToRoman());
    }

    [Fact]
    public void Test_Convert_Value_10()
    {
      var romanNumeral = new RomanNumeral("10");
      Assert.Equal("X",romanNumeral.ConvertToRoman());
    }

    [Fact]
    public void Test_Convert_Value_9()
    {
      var romanNumeral = new RomanNumeral("9");
      Assert.Equal("IX",romanNumeral.ConvertToRoman());
    }

    [Fact]
    public void Test_Convert_Value_50()
    {  
      var romanNumeral = new RomanNumeral("50");
      Assert.Equal("L",romanNumeral.ConvertToRoman());   
    }

    [Fact]
    public void Test_Convert_Value_40()
    {  
      var romanNumeral = new RomanNumeral("40");
      Assert.Equal("XL",romanNumeral.ConvertToRoman());   
    }

    [Fact]
    public void Test_Convert_Value_49()
    {  
      var romanNumeral = new RomanNumeral("49");
      Assert.Equal("XLIX",romanNumeral.ConvertToRoman());   
    }
}
