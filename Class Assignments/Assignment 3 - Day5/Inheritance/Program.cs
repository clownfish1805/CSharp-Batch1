namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

           
            Student student = new Student(101, "Alice", "Second Year", 4, "CSE", new int[5]);

            student.getMarks();
            student.displayResult();
            student.displayData();

        }
    }
}
