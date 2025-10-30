// See https://aka.ms/new-console-template for more information

for(int i = 1; i <= 3000; i++)
{
    var romanNumeral = new RomanNumeral(i.ToString());
    Console.WriteLine(romanNumeral.ConvertToRoman());
}

