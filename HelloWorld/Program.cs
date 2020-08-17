using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Hello World");
          Console.WriteLine("\nWhat is your name? ");
          string name = Console.ReadLine();
          DateTime date = DateTime.Now;
          if(name=="Alice"||name=="Bob")
          {
          Console.WriteLine($"\nHello, {name}, on {date:D} at {date:t}!");
          }
          Console.Write("\nPress any key to exit...");
          Console.ReadKey(false);
        }
    }
}
