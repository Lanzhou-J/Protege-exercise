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
          // Mentors advice: Meaningful naming.(i and j => factors)
          // Mentors advice: Use terminology instead of create ...
          // for(int secondFactor = 1; secondFactor <= 12; secondFactor++){
          //   List <string> multiplicationTableRow = new List <string>(); 
          //   for(int firstFactor = 1; firstFactor <= secondFactor; firstFactor++){
          //     multiplicationTableRow.Add($"{firstFactor}*{secondFactor}={firstFactor*secondFactor}");
          //   }
          //   Console.WriteLine(string.Join(", ", multiplicationTableRow));              
          // }


          // // basic-kata-8
          // Console.WriteLine("Please input a number from 1 to 100: ");
          // int inputNumber = int.Parse(Console.ReadLine());
          // int secretNumber;
          // // Random number generator
          // Random randomNumberGenerator = new Random();
          // secretNumber = randomNumberGenerator.Next(1,100);
          // int previousNumber = inputNumber - 1;
          // int tries = 1;
          // // Mentors advice: take Meaningful words form requirements
          // // Mentors advice: change randomNumber to secretNumber
          // // Mentors advice: number => actually input
          // while(inputNumber != secretNumber){
          //   if(inputNumber > secretNumber){
          //     Console.WriteLine("Too large! Please try again:");
          //     if(inputNumber != previousNumber){
          //       tries++;
          //     }       
          //   }else if(inputNumber < secretNumber){
          //     Console.WriteLine("Too small! Please try again:");
          //     if(inputNumber != previousNumber){
          //       tries++;
          //     }
          //   }
          //   previousNumber = inputNumber;
          //   inputNumber = int.Parse(Console.ReadLine());
          // }
          // Console.WriteLine("Correct!🎉");
          // Console.WriteLine($"You have tried {tries} times.");

          // // basic-kata-9
          int counts = 0;
          int year = 2021;
          // Mentors advice: Don't need to use list here.
          Console.WriteLine("The next 20 leap years:");
          do {
            if((year % 100 != 0 & year % 4 == 0) | year % 400 == 0){
              counts++;
              Console.WriteLine($"Count {counts}: {year}");
            }
            year++;
          }while(counts<20);
          

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
