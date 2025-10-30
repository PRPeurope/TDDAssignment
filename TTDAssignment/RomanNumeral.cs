public class RomanNumeral
{
  private string input;
  private int value;

  public RomanNumeral(string input)
  {
    this.input = input;
  }
  public bool ValidateInput()
  {
    bool isInt = int.TryParse(input, out value);
    bool isPositive = (value >= 0);
    bool doesNotExceedAmmount = (value <= 3000);
    bool isNotZero = (value != 0);
    return isInt && isPositive && doesNotExceedAmmount && isNotZero;
  }
  
  public string ConvertToRoman()
  {
    ValidateInput();
    string output = "";
    int Vs = value / 5;
    int Is = (value % 5);
    for(int i = 0; i < Vs; i++)
    {
      output += "V";
    }
    for(int i = 0; i < Is; i++)
    {
      output += "I";
    }    
    return output;
  }
}
