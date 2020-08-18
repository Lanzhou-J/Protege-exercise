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
          int Sum(int inputN){
            int number = 1;
            int sum = 0;
            while(number <= inputN){
              sum += number;
              number++;
            }
            return sum;
          }
          Console.WriteLine("Please input a number equal to or larger than 1: ");
          int input = int.Parse(Console.ReadLine());
          Console.WriteLine(Sum(input));


          // // basic-kata-5
          // Console.WriteLine("Please input a number: ");
          // int number = int.Parse(Console.ReadLine());
          // int startNum = 1;
          // // int sum = 0; 
          // while(startNum <= number){
          //   if(startNum % 3 == 0 || startNum % 5 == 0){
          //     // sum += startNum;
          //     Console.WriteLine(startNum);
          //   }
          //   startNum++;
          // }
          // // Console.WriteLine(sum);


          // // basic-kata-6
          // // Error handling (floats/0/-n)
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


          // // basic-kata-7
          // Meaningful naming.(i and j => factors)
          // Use terminology instead of create ...
          // for(int i = 1; i <= 12; i++){
          //   List <string> list = new List <string>(); 
          //   for(int j = 1; j <= 12; j++){
          //     list.Add($"{j}*{i}={i*j}");
          //   }
          //   Console.WriteLine(string.Join(", ", list));              
          // }


          // // basic-kata-8
          // Console.WriteLine("Please input a number from 1 to 100: ");
          // int number = int.Parse(Console.ReadLine());
          // int randomNumber;
          // // Random number generator
          // Random RNG = new Random();
          // randomNumber = RNG.Next(1,100);
          // int preNum = number - 1;
          // int tries = 1;
          // // take Meaningful words form requirements
          // // change randomNumber to secretNumber
          // // number => actually input
          // while(number!=randomNumber){
          //   if(number>randomNumber){
          //     if(number!=preNum){
          //       tries++;
          //     }
          //     Console.WriteLine("Too large! Please try again:");
          //   }else if(number<randomNumber){
          //     if(number!=preNum){
          //       tries++;
          //     }
          //     Console.WriteLine("Too small! Please try again:");
          //   }
          //   preNum = number;
          //   number = int.Parse(Console.ReadLine());
          // }
          // Console.WriteLine("Correct!🎉");
          // Console.WriteLine($"You have tried {tries} times.");

          // // basic-kata-9
          // int counts = 0;
          // int year = 2020;
          // // Don't need to use list here.
          // List <int> leapYearList = new List <int>(); 
          // do {
          //   if((year % 100 != 0 & year % 4 == 0) | year % 400 == 0){
          //     leapYearList.Add(year);
          //     counts++;
          //   }
          //   year++;
          // }while(counts<20);
          // Console.WriteLine("The next 20 leap years:");
          // leapYearList.ForEach(Console.WriteLine);

          //Kata-Fizzbuzz
          // for(int i = 1; i <= 100; i++){
          //   string newStr="";
          //   if(i%3==0){
          //     newStr += "Fizz";
          //   }
          //   if(i%5==0){
          //     newStr += "Buzz";
          //   }
          //   var result = (newStr.Length==0)?$"{i}":newStr;
          //   Console.WriteLine(result);
          // }

        }
    }
}
