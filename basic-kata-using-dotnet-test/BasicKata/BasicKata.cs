using System;
using System.Collections.Generic;
using System.Linq;
// using System.Text;

namespace Basic.Kata
{
    public class BasicKata
    {
        public int CalculateSumOfOneToN(string inputNString)
        {
            int inputN = int.Parse(inputNString);
            if (inputN < 1)
            {
               throw new ArgumentException("Invalid input");
            }
            int addend = 1;
            int oneToNSum = 0;
            while (addend <= inputN)
            {
               oneToNSum += addend;
               addend++;
            }
            return oneToNSum;
        }

        public List<string> FizzBuzz() {
            List<string> fizzBuzzList = new List<string>();
            for (int i = 1; i <= 100; i++)
            {
                string fizzBuzzString = "";
                if (i % 3 == 0)
                {
                    fizzBuzzString += "Fizz";
                }
                if (i % 5 == 0)
                {
                    fizzBuzzString += "Buzz";
                }
                var result = (fizzBuzzString.Length == 0) ? $"{i}" : fizzBuzzString;
                fizzBuzzList.Add(result);
            }
            return fizzBuzzList;
        }

        public void GuessASecretNumber()
        {
            Console.WriteLine("Please input a number from 1 to 100: ");
            int inputNumber = 0;
            int secretNumber;
            // Random number generator
            Random randomNumberGenerator = new Random();
            secretNumber = randomNumberGenerator.Next(1, 100);
            int previousNumber = -1;
            int tries = 1;
            // Mentors advice: take Meaningful words form requirements
            // Mentors advice: change randomNumber to secretNumber
            // Mentors advice: number => actually input
            do 
            {
                inputNumber = int.Parse(Console.ReadLine());
                if (inputNumber > secretNumber)
                {
                    Console.WriteLine("Too large! Please try again:");
                    if (inputNumber != previousNumber)
                    {
                        tries++;
                    }
                }
                else if (inputNumber < secretNumber)
                {
                    Console.WriteLine("Too small! Please try again:");
                    if (inputNumber != previousNumber)
                    {
                        tries++;
                    }
                }
                previousNumber = inputNumber;
                inputNumber = int.Parse(Console.ReadLine());
            } while (inputNumber == secretNumber);

            Console.WriteLine("Correct!🎉");
            Console.WriteLine($"You have tried {tries} times.");
        }
    }
}
