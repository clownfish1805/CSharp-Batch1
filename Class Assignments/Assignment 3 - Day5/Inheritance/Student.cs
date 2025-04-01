using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance
{
    class Student
    {
        public int rollno { get; set; }
        public string name { get; set; }
        public string year { get; set; }
        public int semester { get; set; }
        public string branch { get; set; }
        public int[] marks = new int[5];

        private double avg;
        private String result;

        public Student(int rollno, string name, string year, int semester, string branch, int[] marks)
        {
            this.rollno = rollno;
            this.name = name;
            this.year = year;
            this.semester = semester;
            this.branch = branch;
            this.marks = marks;
        }
        public void getMarks()
        {
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine($"Enter {i+1} mark:");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void displayResult()
        {
            int count = 0;
           

            for(int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < 35)
                {
                    result = "Failed";
                    avg = 0;
                    return;

                }
                else
                {
                    count += marks[i];
                }
                    
            }

            avg = count / 5.0;
            if(count > 35 && avg < 50)
            {
                Console.WriteLine(result);

            }
            else {
                result = "Passed";
                Console.WriteLine(result);

            }

        }

        public void displayData()
        {
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Student Details");
            Console.WriteLine($"Roll No: {rollno}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {year}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");
            Console.WriteLine($"Average Marks: {avg}");  
            Console.WriteLine($"Result: {result}");

        }
    }
}
