using System;

namespace CalculatorApp
{
    internal class Calculator
    {
        static void Main()
        {
            Console.WriteLine("Simple Calculator");

            while (true)
            {
                Console.Write("Enter first number: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.Write("Enter operator (+, -, *, /): ");
                char op = Console.ReadKey().KeyChar;
                Console.WriteLine();

                Console.Write("Enter second number: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                double result = 0;

                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero. Please enter a non-zero divisor.");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operator. Please enter a valid operator (+, -, *, /).");
                        continue;
                }

                Console.WriteLine($"Result: {result}");

                Console.Write("Do you want to perform another calculation? (y/n): ");
                char response = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (response != 'y')
                {
                    break;
                }
            }
        }
    }
}
