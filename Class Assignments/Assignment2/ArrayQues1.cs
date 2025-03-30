using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class ArrayQues1
    {
        private static int[] array = { 1, 2, 3, 4, 5, 6 };
        public static void Arrayans1()
        {
            
            double avg_arr = array.Average();
            Console.WriteLine($"Average array: {avg_arr}");
        }
        public static void Arrayans2() {
            int max = array.Max();
            Console.WriteLine($"Max element: {max}");
            int min = array.Min();
            Console.WriteLine($"Min element: {min}");
        } 
    }
}
