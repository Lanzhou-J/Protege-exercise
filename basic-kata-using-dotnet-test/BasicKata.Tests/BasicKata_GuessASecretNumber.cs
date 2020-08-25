using Xunit;
using Basic.Kata;
using System;
using Xunit.Abstractions;

namespace Basic.UnitTests.Kata
{
    public class BasicKata_GuessASecretNumberShould
    {

        private readonly ITestOutputHelper _testOutputHelper;

        public BasicKata_GuessASecretNumberShould(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }


        //[Fact]
        //public void GuessGameShouldOutputPleaseInputANumber()
        //{
        //    GuessASecretNumber("2");
        //    _testOutputHelper.WriteLine("Please input a number from 1 to 100: ");
        //}
    }
}