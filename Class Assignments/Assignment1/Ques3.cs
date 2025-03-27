using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Ques3
    {
        static void check3()
        {
            Console.Write("Input first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input operation: ");
            char operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Input second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case '/':
                    if (num2 != 0)
                        Console.WriteLine($"{num1} / {num2} = {num1 / (double)num2}");
                    else
                        Console.WriteLine("Cannot divide by zero.");
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
        }

    }
}
