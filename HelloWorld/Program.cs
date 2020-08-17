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
          // int Sum(int number){
          //   int flagnum = 1;
          //   int sum = 0;
          //   while(flagnum <= number){
          //     sum += flagnum;
          //     flagnum++;
          //   }
          //   // Console.WriteLine(sum);
          //   return sum;
          // }
          // Console.WriteLine("Please input a number: ");
          // int number = int.Parse(Console.ReadLine());
          // Console.WriteLine(Sum(number));


          // // basic-kata-5
          // Console.WriteLine("Please input a number: ");
          // int number = int.Parse(Console.ReadLine());
          // int startNum = 1;
          // int sum = 0; 
          // while(startNum <= number){
          //   if(startNum % 3 == 0 | startNum % 5 == 0){
          //     sum += startNum;
          //   }
          //   startNum++;
          // }
          // Console.WriteLine(sum);


          // // basic-kata-6
          //   Console.WriteLine("Please input a number: ");
          //   int number = int.Parse(Console.ReadLine());
          //   Console.WriteLine("\nSelect 1 to computing the sum of 1,...,n "); 
          //   Console.WriteLine("\nSelect 2 to computing the product of 1,...,n ");
          //   Console.WriteLine(">>> ");
          //   int selection = int.Parse(Console.ReadLine());
          //   //product function
          //   int Product(int number){
          //     int startNum = 1;
          //     int product = 1;
          //     while(startNum <= number){
          //       product *= startNum;
          //       startNum++;              
          //     }
          //     return product;
          //   }

          //   switch (selection)
          //   {
          //     case 1:
          //       Console.WriteLine(Sum(number));
          //       break;
          //     case 2:
          //       Console.WriteLine(Product(number));
          //       break;
          // }


          // basic-kata-7
          for(int i = 1; i <= 12; i++){
            List <int> list = new List <int>(); 
            for(int j = 1; j <= 12; j++){
              list.Add(i*j);
            }
            Console.WriteLine(string.Join(", ", list));              
          }                             
        }
    }
}
