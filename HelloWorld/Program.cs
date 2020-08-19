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
          // int calculateSumOfOneToN(int inputN){
          //   int addend = 1;
          //   int oneToNSum = 0;
          //   while(addend <= inputN){
          //     oneToNSum += addend;
          //     addend++;
          //   }
          //   return oneToNSum;
          // }
          // Console.WriteLine("Please input a number(n) equal to or larger than 1: ");
          // int inputN = int.Parse(Console.ReadLine());
          // Console.WriteLine("Sum of the numbers 1 to n: " + calculateSumOfOneToN(inputN));


          // // basic-kata-5
          // Console.WriteLine("Please input a number(n) equal to or larger than 1: ");
          // int inputN = int.Parse(Console.ReadLine());
          // int loopNumber = 1;
          // int multipleOfThreeOrFiveSum = 0; 
          // while(loopNumber <= inputN){
          //   if(loopNumber % 3 == 0 || loopNumber % 5 == 0){
          //     multipleOfThreeOrFiveSum += loopNumber;
          //     // Console.WriteLine(loopNumber);
          //   }
          //   loopNumber++;
          // }
          // Console.WriteLine("Sum of the numbers 1 to n if the number is a multiple of three or five:");
          // Console.WriteLine(multipleOfThreeOrFiveSum);


          // // basic-kata-6
          // // Mentors advice: Error handling (floats/0/-n)
          //   Console.WriteLine("Please input a number(n) equal to or larger than 1: ");
          //   int inputN = int.Parse(Console.ReadLine());
          //   Console.WriteLine("\nSelect 1 for computing the sum of 1,...,n "); 
          //   Console.WriteLine("\nSelect 2 for computing the product of 1,...,n ");
          //   Console.WriteLine("\nYour selection is: ");
          //   int selection = int.Parse(Console.ReadLine());
          //   //product function
          //   int calculateProductOfOneToN(int inputN){
          //     int factor = 1;
          //     int oneToNProduct = 1;
          //     while(factor <= inputN){
          //       oneToNProduct *= factor;
          //       factor++;              
          //     }
          //     return oneToNProduct;
          //   }
          //   switch (selection)
          //   {
          //     case 1:
          //       Console.WriteLine("Sum of the numbers 1 to n: " + calculateSumOfOneToN(inputN));
          //       break;
          //     case 2:
          //       Console.WriteLine("Product of the numbers 1 to n: " + calculateProductOfOneToN(inputN));
          //       break;
          // }


          // // basic-kata-7
          // Meaningful naming.(i and j => factors)
          // Use terminology instead of create ...
          for(int secondFactor = 1; secondFactor <= 12; secondFactor++){
            List <string> multiplicationTableRow = new List <string>(); 
            for(int firstFactor = 1; firstFactor <= secondFactor; firstFactor++){
              multiplicationTableRow.Add($"{firstFactor}*{secondFactor}={firstFactor*secondFactor}");
            }
            Console.WriteLine(string.Join(", ", multiplicationTableRow));              
          }


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
