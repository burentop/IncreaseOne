using System;

class IncreaseOne
{
  static void Main()
  {
    Console.WriteLine("Enter a number: ");
    int inputNumber = int.Parse(Console.ReadLine());
    if (inputNumber >= 0)
    {
        inputNumber += 1;
    } else
    {
        inputNumber -= 1;
    }
    Console.WriteLine("Here, I changed it for you: " + inputNumber.ToString());
  }
}