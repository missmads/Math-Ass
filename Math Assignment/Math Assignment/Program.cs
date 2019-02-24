using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();

            Console.WriteLine("Give me a number!");
            Console.WriteLine("It has to be a whole number, and may therefore not contain deciman numbers");
            Console.WriteLine("If you would like, you can try to go with a decimal number, but it might not work though");
            string firstNumberTotallyNotADecimalNumberLetter = Console.ReadLine();
            int firstNumberOutOfManyNumbersToComeInTheNearestFuture = int.Parse(firstNumberTotallyNotADecimalNumberLetter);
     
            Console.WriteLine("Good. That Worked Perfektly. Now give me another, or same, number!");
            Console.WriteLine("But seriously! Dont do the F*cking Decimal numbers!");
            string secondNumberTotallyNotADecimalNumberLetter = Console.ReadLine();
            int secondNumberOutOfManyNumbersToComeInTheNearestFuture = int.Parse(secondNumberTotallyNotADecimalNumberLetter);

            if (firstNumberOutOfManyNumbersToComeInTheNearestFuture == secondNumberOutOfManyNumbersToComeInTheNearestFuture)
            {
                int newNumberOutOfManyNumbersToComeInTheNearestFuture = firstNumberOutOfManyNumbersToComeInTheNearestFuture + secondNumberOutOfManyNumbersToComeInTheNearestFuture;
                int finalNumberOutOfManyNumbersToComeInTheNearestFuture = newNumberOutOfManyNumbersToComeInTheNearestFuture + newNumberOutOfManyNumbersToComeInTheNearestFuture + newNumberOutOfManyNumbersToComeInTheNearestFuture;
                Console.WriteLine(finalNumberOutOfManyNumbersToComeInTheNearestFuture);
            }
            else
            {
                Console.WriteLine(firstNumberOutOfManyNumbersToComeInTheNearestFuture + secondNumberOutOfManyNumbersToComeInTheNearestFuture);
            }

            Console.ReadLine();
        }
    }
}