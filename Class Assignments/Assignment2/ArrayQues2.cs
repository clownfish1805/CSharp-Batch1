using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class ArrayQues2
    {
        public static void Arrayans2()
        {
            int[] marks = new int[10];

            Console.WriteLine("Enter 10 marks:");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Mark {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }
            Console.WriteLine($"Total Marks: {total}");

            double average = marks.Average();
            Console.WriteLine($"Average Marks: {average}");

            int min = marks.Min();
            Console.WriteLine($"Minimum Marks: {min}");

            int max = marks.Max();
            Console.WriteLine($"Maximum Marks: {max}");

            int[] sortedMarks = (int[])marks.Clone();
            Array.Sort(sortedMarks);

            Console.WriteLine("Marks in Ascending Order: " + string.Join(" ", sortedMarks));

            Array.Reverse(sortedMarks);
            Console.WriteLine("Marks in Descending Order: " + string.Join(" ", sortedMarks));


        }

      
    
    
    }
}
