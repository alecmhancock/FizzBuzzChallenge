﻿namespace FizzBuzzChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            double num = double.Parse(Console.ReadLine());
            string test = FizzBuzz(num);
            Console.WriteLine(test);
        }
        static string FizzBuzz(double num)
        {
            //string output = "";
            //if (num % 3 == 0 && num % 5 == 0)
            //{ return output += "fizzbuzz"; }
            //else if (num % 5 == 0)
            //{ return output += "buzz"; }
            //else if (num % 3 == 0)
            //{ return output += "fizz"; }
            //else
            //{ return output += "Input number not divisible by 3 or 5!"; }

            
            {
                return (num % 3, num % 5) switch
                {
                    (0, 0) => "FizzBuzz",
                    (0, _) => "Fizz",
                    (_, 0) => "Buzz",
                    (_, _) => "Input number not divisible by 3 or 5!"
                };
            }
        }
    }
}