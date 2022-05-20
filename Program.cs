using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <= 100; number++)
            {
                var isDivideByThree = number % 3 == 0;
                var isDivideByFive = number % 5 == 0;

                if (isDivideByThree && isDivideByFive)
                    Console.WriteLine("FizzBuzz");
                else if (isDivideByThree)
                    Console.WriteLine("Fizz");
                else if (isDivideByFive)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(number);
            }
        }
    }
}
