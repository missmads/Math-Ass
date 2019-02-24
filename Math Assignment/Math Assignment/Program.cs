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
            string firstNumberLetter = Console.ReadLine();
            int firstNumber = int.Parse(firstNumberLetter);
     
            Console.WriteLine("Good. Now give me another, or same, number!");
            string secondNumberLetter = Console.ReadLine();
            int secondNumber = int.Parse(secondNumberLetter);

            if (firstNumber == secondNumber)
            {
                int newNumber = firstNumber + secondNumber;
                int finalNumber = newNumber + newNumber + newNumber;
                Console.WriteLine(finalNumber);
            }
            else
            {
                Console.WriteLine(firstNumber + secondNumber);
            }

            Console.ReadLine();
        }
    }
}