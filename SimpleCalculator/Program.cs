using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float firstNumber, secondNumber, result = 0;
            bool checkNumber;
            string enteredOperator;

            string[] mathOperator = new string[4] {"+", "-", "*", "/"};

            // Welcome text
            Console.WriteLine("Welcome to: Simple Console Calculator!");
            Console.WriteLine("");
            Console.WriteLine("Available operations: addition, subtraction, multiplication, division.");
            Console.WriteLine("");
            Console.WriteLine("Start by entering number!");
            Console.WriteLine("");

            // Main loop
            while (true)
            {
                // Reciving first number from user
                do
                {
                    Console.WriteLine("------");
                    Console.Write("First number: ");
                    checkNumber = float.TryParse(Console.ReadLine(), out firstNumber);

                    if (!checkNumber)
                    {
                        Console.WriteLine("!!!");
                        Console.WriteLine("error, enter a number!");
                        Console.WriteLine("!!!");
                    }
                }
                while (!checkNumber);

                // Reciving math operator from user
                do
                {
                    Console.Write("Math operator: ");
                    enteredOperator = Console.ReadLine();

                    if (!mathOperator.Contains(enteredOperator))
                    {
                        Console.WriteLine("!!!");
                        Console.WriteLine("error, enter correct math operator(+,-,*,/)!");
                        Console.WriteLine("!!!");
                    }
                }
                while (!mathOperator.Contains(enteredOperator));

                // Reciving second number from user
                do
                {
                    Console.Write("Second number: ");
                    checkNumber = float.TryParse(Console.ReadLine(), out secondNumber);

                    if (!checkNumber)
                    {
                        Console.WriteLine("!!!");
                        Console.WriteLine("error, enter a number!");
                        Console.WriteLine("!!!");
                    }
                }
                while (!checkNumber);

                // Performing math operations
                switch (enteredOperator)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        result = firstNumber / secondNumber;
                        break;
                }

                // Printing result
                Console.WriteLine("");
                Console.WriteLine($"Result: {firstNumber} {enteredOperator} {secondNumber} = {result}");
                Console.WriteLine("");
            }

        }
    }
}
