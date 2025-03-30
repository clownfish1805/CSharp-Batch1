using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Ques2
    {
        public static void AnswerQues2()
        {
            Console.Write("Enter a digit: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} {0} {0} {0}", num);
                Console.WriteLine("{0}{0}{0}{0}", num);
            }
        }
    }
}
