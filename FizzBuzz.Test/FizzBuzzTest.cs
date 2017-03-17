using FizzBuzz.Service;
using FizzBuzz.Service.Exception;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzz.Test
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Fizzbuzz_TestCase_1()
        {
            var fizzBuzz = new FizzBuzzService().GetFizzBuzzResult(1);
            Assert.Equal("1", fizzBuzz);
        }
        [Fact]
        public void Fizzbuzz_TestCase_2()
        {
            var fizzBuzz = new FizzBuzzService().GetFizzBuzzResult(2);
            Assert.Equal("2", fizzBuzz);
        }
        [Fact]
        public void Fizzbuzz_TestCase_3()
        {
            var fizzBuzz = new FizzBuzzService().GetFizzBuzzResult(3);
            Assert.Equal("Fizz", fizzBuzz);
        }
        [Fact]
        public void Fizzbuzz_TestCase_4()
        {
            var fizzBuzz = new FizzBuzzService().GetFizzBuzzResult(4);
            Assert.Equal("4", fizzBuzz);
        }
        [Fact]
        public void Fizzbuzz_TestCase_5()
        {
            var fizzBuzz = new FizzBuzzService().GetFizzBuzzResult(5);
            Assert.Equal("Buzz", fizzBuzz);
        }
        [Fact]
        public void Fizzbuzz_TestCase_6()
        {
            var fizzBuzz = new FizzBuzzService().GetFizzBuzzResult(6);
            Assert.Equal("Fizz", fizzBuzz);
        }
        [Fact]
        public void Fizzbuzz_TestCase_7()
        {
            var fizzBuzz = new FizzBuzzService().GetFizzBuzzResult(7);
            Assert.Equal("7", fizzBuzz);
        }
        [Fact]
        public void Fizzbuzz_TestCase_8()
        {
            var fizzBuzz = new FizzBuzzService().GetFizzBuzzResult(8);
            Assert.Equal("8", fizzBuzz);
        }
        [Fact]
        public void Fizzbuzz_TestCase_9()
        {
            var fizzBuzz = new FizzBuzzService().GetFizzBuzzResult(9);
            Assert.Equal("Fizz", fizzBuzz);
        }
        [Fact]
        public void Fizzbuzz_TestCase_10()
        {
            var fizzBuzz = new FizzBuzzService().GetFizzBuzzResult(10);
            Assert.Equal("Buzz", fizzBuzz);
        }
        [Fact]
        public void Fizzbuzz_TestCase_11()
        {
            var fizzBuzz = new FizzBuzzService().GetFizzBuzzResult(11);
            Assert.Equal("11", fizzBuzz);
        }
        [Fact]
        public void Fizzbuzz_TestCase_12()
        {
            var fizzBuzz = new FizzBuzzService().GetFizzBuzzResult(12);
            Assert.Equal("Fizz", fizzBuzz);
        }
        [Fact]
        public void Fizzbuzz_TestCase_13()
        {
            var fizzBuzz = new FizzBuzzService().GetFizzBuzzResult(13);
            Assert.Equal("13", fizzBuzz);
        }
        [Fact]
        public void Fizzbuzz_TestCase_14()
        {
            var fizzBuzz = new FizzBuzzService().GetFizzBuzzResult(14);
            Assert.Equal("14", fizzBuzz);
        }
        [Fact]
        public void Fizzbuzz_TestCase_15()
        {
            var fizzBuzz = new FizzBuzzService().GetFizzBuzzResult(15);
            Assert.Equal("Fizz Buzz", fizzBuzz);
        }
    }
}
