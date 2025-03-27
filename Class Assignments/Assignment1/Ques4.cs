using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Ques4
    {
        static void check4()
        {
            Console.Write("Enter the number: ");

            int num1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num1} * {i} = {num1 * i}");
            }
        }
    }
}
