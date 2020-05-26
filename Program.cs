using System;
using System.Threading;

namespace MagicEightBall
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      Console.Write("What would you like advice on? ");
      Console.ReadLine();

      Console.Clear();

      Console.Write("Looking into the future...");
      Thread.Sleep(1000);

      Console.Clear();

      // create eight ball object and get answer
      MagicEightBall magicEightBall = new MagicEightBall();
      Console.WriteLine(magicEightBall.GetAnswer());
      Console.Write("Press any key to finish.");
      Console.ReadLine();

      Console.Clear();
    }
  }
}
