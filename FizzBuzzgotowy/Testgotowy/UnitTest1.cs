using NUnit.Framework;
using System.Collections.Generic;
using FizzBuzzgotowy;

namespace Testgotowy
{
    public class Tests
    {
        [Test]
        public void SimpleBuzzingaTest() //podzielność przez 7
        {
            List<int> numbers = new List<int>() { 1, 7, 28 };
            List<string> expectedResults = new List<string>() { "1", "Buzzinga", "Buzzinga" };
            var actualResults = FizzBuzzer.MillNumbers(numbers);
            CollectionAssert.AreEqual(expectedResults[0], actualResults[0]);
        }

        [Test]
        public void SimpleFizzSingleTest()
        {
            List<int> numbers = new List<int>() { 3, 13 };
            List<string> expectedResults = new List<string>() { "Fizz", "13" };
            var actualResults = FizzBuzzer.MillNumbers(numbers);
            CollectionAssert.AreEqual(expectedResults[0], actualResults[0]);
        }

        [Test]
        public void SimpleBuzzTest()
        {
            List<int> numbers = new List<int>() { 1, 5, 10, 51 };
            List<string> expectedResults = new List<string>() { "1", "Buzz", "Buzz", "Buzz" };
            var actualResluts = FizzBuzzer.MillNumbers(numbers);
            CollectionAssert.AreEqual(expectedResults, actualResluts);
        }

        [Test]
        public void SimpleFizzTest()
        {
            List<int> numbers = new List<int>() { 3, 6, 9, 12 };
            List<string> expectedResults = new List<string>() { "Fizz", "Fizz", "Fizz", "Fizz" };
            var actualResluts = FizzBuzzer.MillNumbers(numbers);
            CollectionAssert.AreEqual(expectedResults, actualResluts);
        }

        [Test]
        public void SimpleFizzBuzzTest()
        {
            List<int> numbers = new List<int>() { 1, 15, 538, 352, 36753, 9354 };
            List<string> expectedResults = new List<string>() { "1", "FizzBuzz", "FizzBuzz", "FizzBuzz", "FizzBuzz", "FizzBuzz" };
            var actualResluts = FizzBuzzer.MillNumbers(numbers);
            CollectionAssert.AreEqual(expectedResults, actualResluts);
        }

        [Test]
        public void MoreRealisticTest()
        {
            List<int> numbers = new List<int>() {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<string> expectedResults = new List<string>() {
                "1","2","Fizz","4","Buzz","Fizz","Buzzinga","8","Fizz","Buzz",
                 "11","Fizz","13","Buzzinga","FizzBuzz","16","17","Fizz","19","Buzz"};
            var actualResluts = FizzBuzzer.MillNumbers(numbers);
            CollectionAssert.AreEqual(expectedResults, actualResluts);
        }
    }
}
