using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class ArrayQues3
    {
       public static void Arrayans3()
        {
            int[] arr1 = { 10, 20, 30, 40, 50 };
            int[] arr2 = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i]; 
            }

            Console.WriteLine("Source Array: " + string.Join(" ", arr1));
            Console.WriteLine("Copied Array: " + string.Join(" ", arr2));
        
    }
    }
}
