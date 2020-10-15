using System;

class MainClass {
  public static double IntegerPower(double n, int p)
  {
    double result = 1;
    for (int x = 0; x < p; x++)
    {
      result *= n;
    }
    return(result);
  }
  public static void Main (string[] args) {
    Console.Write("Enter Integer: ");
    double i = double.Parse(Console.ReadLine());
    Console.Write("Enter Power: ");
    int p = int.Parse(Console.ReadLine());
    Console.WriteLine(IntegerPower(i, p));
  }
}