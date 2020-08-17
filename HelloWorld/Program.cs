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
          Console.WriteLine("Please input a number: ");
          int number = int.Parse(Console.ReadLine());
          Console.WriteLine(number);
          int flagnum = 1;
          int sum = 0;
          while(flagnum <= number){
            sum += flagnum;
            flagnum++;
          }
          Console.WriteLine(sum);
        }
    }
}
