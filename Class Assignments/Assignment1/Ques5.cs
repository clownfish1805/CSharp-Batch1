using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Ques5
    {
        static void check()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            if (num1 == num2)
                Console.WriteLine($"Result: {sum * 3}");
            else
                Console.WriteLine($"Result: {sum}");
        }
    }
}
