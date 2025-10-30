public class RomanNumeral
{
  private string input;

  public RomanNumeral(string input)
  {
    this.input = input;
  }
  public bool ValidateInput()
  {
    return int.TryParse(input, out int value);
  }
}
