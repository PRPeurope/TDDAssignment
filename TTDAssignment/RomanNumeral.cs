public class RomanNumeral
{
  private string input;

  public RomanNumeral(string input)
  {
    this.input = input;
  }
  public bool ValidateInput()
  {
    bool isInt = int.TryParse(input, out int value);
    bool isPositive = (value >= 0);
    bool doesNotExceedAmmount = (value <= 3000);
    bool isNotZero = (value != 0);
    return isInt && isPositive && doesNotExceedAmmount && isNotZero;
  }
}
