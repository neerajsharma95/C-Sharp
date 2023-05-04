using System;

namespace MyApplication
{
  class Program
  {
    static void Circumference(int r)
    {
      Console.WriteLine("Circumference "+2*3.14*r);
    }

    static void Main(string[] args)
    {
      int radius=7;
      Circumference(radius);
    }
  }
}