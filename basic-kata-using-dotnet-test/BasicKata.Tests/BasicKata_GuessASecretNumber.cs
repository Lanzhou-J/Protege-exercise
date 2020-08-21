using Xunit;
using Basic.Kata;
using System;
using Xunit.Abstractions;

namespace Basic.UnitTests.Kata
{
    public class BasicKata_GuessASecretNumberShould
    {
        string GuessASecretNumber(string inputNumberString)
        {
            Console.WriteLine("Please input a number from 1 to 100: ");
            int inputNumber = int.Parse(inputNumberString);
            int secretNumber;
            // Random number generator
            Random randomNumberGenerator = new Random();
            secretNumber = randomNumberGenerator.Next(1, 100);
            int previousNumber = -1;
            int tries = 1;
            // Mentors advice: take Meaningful words form requirements
            // Mentors advice: change randomNumber to secretNumber
            // Mentors advice: number => actually input
            while (inputNumber != secretNumber)
            {
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
            }
            return("Correct!🎉"+ $"You have tried {tries} times.");
        }

        private readonly ITestOutputHelper _testOutputHelper;

        public BasicKata_GuessASecretNumberShould(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }


        [Fact]
        public void GuessGameShouldOutputPleaseInputANumber()
        {
            GuessASecretNumber("2");
            _testOutputHelper.WriteLine("Please input a number from 1 to 100: ");
        }
    }
}