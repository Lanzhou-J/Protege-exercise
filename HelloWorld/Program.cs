using System;
using System.Collections.Generic;
using System.Linq;
// using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          // // basic-kata-4
          // Console.WriteLine("Please input a number: ");
          // int number = int.Parse(Console.ReadLine());
          // Console.WriteLine(number);
          // int flagnum = 1;
          // int sum = 0;
          // while(flagnum <= number){
          //   sum += flagnum;
          //   flagnum++;
          // }
          // Console.WriteLine(sum);

          // basic-kata-5
          // List <int> numList = new List <int>();
          Console.WriteLine("Please input a number: ");
          int number = int.Parse(Console.ReadLine());
          // Console.WriteLine(number);
          int startNum = 1;
          int sum = 0; 
          while(startNum <= number){
            if(startNum % 3==0 | startNum % 5==0){
              sum += startNum;
            }
            startNum++;
          }
          Console.WriteLine(sum);
        }
    }
}
