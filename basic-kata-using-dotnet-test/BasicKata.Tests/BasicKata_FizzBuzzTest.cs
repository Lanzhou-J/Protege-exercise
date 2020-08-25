using Xunit;
using Basic.Kata;
using System;
using System.Collections.Generic;

namespace Basic.UnitTests.Kata
{
    public class BasicKata_FizzBuzzShould
    {
        private readonly BasicKata _basicKata;

        public BasicKata_FizzBuzzShould()
        {
            _basicKata = new BasicKata();
        }

        [Fact]
        public void FizzBuzz_ReturnAListOfStrings()
        {
            var result = _basicKata.FizzBuzz();

            Assert.Equal(typeof(List<string>), result.GetType());
        }

        [Fact]
        public void FizzBuzz_TheReturnedListShouldHave100Items() {
            var result = _basicKata.FizzBuzz();
            int length = result.Count;
            Assert.Equal(100, length);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(18)]
        [InlineData(33)]
        [InlineData(42)]
        public void FizzBuzz_MultiplesOf3thButNotMultipleOf5thItemsShouldBeFizz(int count)
        {
            var result = _basicKata.FizzBuzz();
            var actualIndex = count - 1;
            Assert.Equal("Fizz", result[actualIndex]);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(20)]
        [InlineData(35)]
        [InlineData(65)]
        [InlineData(100)]
        public void FizzBuzz_MultiplesOf5thButNotMultipleOf3thItemsShouldBeBuzz(int count)
        {
            var result = _basicKata.FizzBuzz();
            var actualIndex = count - 1;
            Assert.Equal("Buzz", result[actualIndex]);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(45)]
        [InlineData(75)]
        public void FizzBuzz_MultiplesOf3and5thItemsShouldBeBuzz(int count)
        {
            var result = _basicKata.FizzBuzz();
            var actualIndex = count - 1;
            Assert.Equal("FizzBuzz", result[actualIndex]);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(13)]
        [InlineData(61)]
        [InlineData(73)]
        public void FizzBuzz_NotMultiplesOf3thAndNotMultipleOf5thItemShouldBeAStringWithLengthLessThan4(int count)
        {
            var result = _basicKata.FizzBuzz();
            var actualIndex = count - 1;
            Assert.Equal(count.ToString(), result[actualIndex]);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(13)]
        [InlineData(61)]
        [InlineData(73)]
        public void FizzBuzz_NotMultiplesOf3thAndNotMultipleOf5thItemShouldNotBeFizzOrBuzzOrFizzBuzz(int count)
        {
            var result = _basicKata.FizzBuzz();
            var actualIndex = count - 1;
            Assert.NotEqual("Buzz", result[actualIndex]);
            Assert.NotEqual("Fizz", result[actualIndex]);
            Assert.NotEqual("FizzBuzz", result[actualIndex]);
        }
    }

}