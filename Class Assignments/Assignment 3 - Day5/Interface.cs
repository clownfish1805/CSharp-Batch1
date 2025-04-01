namespace Interface
{
    interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }
        double Fees { get; set; }
        void ShowDetails();
    }
    class Dayscholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public double Fees { get; set; }
        public Dayscholar(int StudentId, string Name, double Fees)
        {
            this.StudentId = StudentId;
            this.Name = Name;
            this.Fees = Fees; 
        }

        public void ShowDetails()
        {
            Console.WriteLine("--- Day Scholar Details ---");
            Console.WriteLine($"Student ID: {this.StudentId}");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Total Fees: {this.Fees}");
        }
    }

    class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public double Fees { get; set; }
        public double AccommodationFees { get; set; }

        public Resident(int StudentId, string Name, double TuitionFees, double AccommodationFees)
        {
            this.StudentId = StudentId;
            this.Name = Name;
            this.Fees = TuitionFees + AccommodationFees; // Tuition + Accommodation fees
            this.AccommodationFees = AccommodationFees;
        }

        public void ShowDetails()
        {
            Console.WriteLine("--- Resident Student Details ---");
            Console.WriteLine($"Student ID: {this.StudentId}");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Tuition Fees: {this.Fees - this.AccommodationFees}");
            Console.WriteLine($"Accommodation Fees: {this.AccommodationFees}");
            Console.WriteLine($"Total Fees: {this.Fees}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            IStudent dayScholar = new Dayscholar(101, "Alice", 50000);
            dayScholar.ShowDetails();

      
            IStudent resident = new Resident(102, "Bob", 50000, 20000);
            resident.ShowDetails();
        }
    }
}
