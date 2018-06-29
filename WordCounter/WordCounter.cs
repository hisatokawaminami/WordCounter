using System;

namespace PingPong
{
  public class PingPongGenerator
  {
    public void Run()
    {
      Console.WriteLine("Please enter a number:");
      string numberAsString = Console.ReadLine();
      int number = int.Parse(numberAsString);
      for(int i = 1; i <= number; i++)
      {
        string result = ConvertToPingPong(i);
        Console.WriteLine(result);
      }
    }

    public string ConvertToPingPong(int number)
    {
      if (number % 3 == 0 && number % 5 == 0)
        {
          return "PingPong";
        }
        else if (number % 3 == 0)
        {
          return "Ping";
        }
        else if (number % 5 == 0)
        {
          return "Pong";
        }
        return number.ToString();
    }
  }

  public class Program
  {
    public static void Main()
    {
      PingPongGenerator game = new PingPongGenerator();
      game.Run();
    }
  }
}
