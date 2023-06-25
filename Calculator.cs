using System.Collections;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public class Calculator
{
  public static int Add(string numberString)
  {

    if (numberString.Length == 0)
    {
      return 0;
    }
    if (numberString.Length == 1)
    {
      return Int32.Parse(numberString);
    }


    var numbers = SplitOnDelimeter(numberString);
    var result = 0;
    foreach (var number in numbers)
    {
      result += Int32.Parse(number);
    }
    return result;
  }

  private static string[] SplitOnDelimeter(string input)
  {
    char[] delimiters = { ',', ';' };
    var result = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
    return result;
  }

}