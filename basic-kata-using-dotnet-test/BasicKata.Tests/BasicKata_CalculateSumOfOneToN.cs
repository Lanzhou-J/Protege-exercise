using Xunit;
using Basic.Kata;
using System;

namespace Basic.UnitTests.Kata
{
    public class BasicKata_CalculateSumOfOneToNShould
    {
        private readonly BasicKata _basicKata;

        public BasicKata_CalculateSumOfOneToNShould()
        {
            _basicKata = new BasicKata();
        }

        [Fact]
        public void CalculateSumOfOneToN_InputIsString3_Return6()
        {
            var result = _basicKata.CalculateSumOfOneToN("3");

            Assert.Equal(6, result);
        }

        [Fact]
        public void CalculateSumOfOneToN_InputIsString1_Return1()
        {
            var result = _basicKata.CalculateSumOfOneToN("1");

            Assert.Equal(1, result);
        }

        //[Fact]
        //public void CalculateSumOfOneToN_InputIsString4_Return10()
        //{
        //    var result = _basicKata.CalculateSumOfOneToN("4");

        //    Assert.Equal(10, result);
        //}

        //[Fact]
        //public void CalculateSumOfOneToN_InputIsString10_Return55()
        //{
        //    var result = _basicKata.CalculateSumOfOneToN("10");

        //    Assert.Equal(55, result);
        //}

        //[Fact]
        //public void CalculateSumOfOneToN_InputIsString100_Return5050()
        //{
        //    var result = _basicKata.CalculateSumOfOneToN("100");

        //    Assert.Equal(5050, result);
        //}

        //[Fact]
        //public void CalculateSumOfOneToN_InputCanConvertTo1_Return1()
        //{
        //    var result = _basicKata.CalculateSumOfOneToN("1.000");

        //    Assert.Equal(1, result);
        //}

        //[Theory]
        //[InlineData("0")]
        //[InlineData("-1")]
        //[InlineData("-100")]
        //public void ThrowExceptionIfInputNumberLessThan1(string value)
        //{
        //    Assert.Throws<ArgumentException>(() => _basicKata.CalculateSumOfOneToN(value));
        //}

        //[Theory]
        //[InlineData("0.4")]
        //[InlineData("-2.5")]
        //[InlineData("120.8")]
        //public void ThrowExceptionIfInputNumberIsFloat(string value)
        //{
        //    Assert.Throws<FormatException>(() => _basicKata.CalculateSumOfOneToN(value));
        //}

    }

}