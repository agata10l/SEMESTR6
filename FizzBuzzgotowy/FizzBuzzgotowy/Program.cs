using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzgotowy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public static class FizzBuzzer
    {
        public static List<String> MillNumbers(List<int> numbers)
        {
            List<String> results = new List<String>();
            foreach (int number in numbers)
            {


                    if (number % 7 == 0)
                    results.Add("Buzzinga");
                    else if (number % 15 == 0)
                        results.Add("FizzBuzz");
                    else if (number % 5 == 0 && number % 3 != 0)
                        results.Add("Buzz");
                    else if (number % 3 == 0 && number % 5 != 0)
                        results.Add("Fizz");
                    else
                        results.Add(number.ToString());
                
            }
            return results;
        }
    }
}
