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
    int Ms = value / 1000;
    int Mrest = value % 1000;
    int Cs = (value % 500) / 100;
    int Crest = value % 100;
    int Xs = (value % 50) / 10;
    int Xrest = value % 10;
    int Is = value % 5;
    if(Ms == 1)
    {
      output += "M";
    }
    if(Mrest+100 >= 1000)
    {
      output += "M";
    }
    else if(Mrest+100 > 400)
    {
      output += "D";
    } 
    if(Cs <= 3)
    {
      for(int i = 0; i < Cs; i++)
      {
       output += "C";
      }
    }
    else
    {
      output = output.Insert(output.Length-1,"C");
    }
    if(Crest+10 >= 100)
    {
      output += "C";
    }
    else if(Crest+10 > 40)
    {
      output += "L";
    }
    if(Xs <= 3)
    {
      for(int i = 0; i < Xs; i++)
      {
       output += "X";
      }
    }
    else
    {
      output = output.Insert(output.Length-1,"X");
    }
    if(Xrest+1 == 10)
    {
      output += "X";
    }
    else if(Xrest+1 > 4)
    {
      output += "V";
    }
    if(Is <= 3)
    {
      for(int i = 0;i < Is; i++)
      {
        output += "I";
      }
    }
    else
    {
      output = output.Insert(output.Length-1,"I");
    }
    return output;
  }
}
