using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Ques1
    {
        public static void AnswerQues1()
        {
            int num1 = 10, num2 = 20;
            Console.WriteLine($"Before swap: num1={num1} num2={num2}");
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"After swap: num1={num1} num2={num2}");
        }
    }
}
