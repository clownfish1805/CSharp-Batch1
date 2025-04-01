namespace Exception
{
    class InsufficientFundsException : IOException
    {
        public InsufficientFundsException(string message) : base(message)
        {
        }
    }
    class BankAccount
    {
        public string AccountHolder { get; set; }
        public double Balance { get; private set; }

        public BankAccount(string accountHolder, double initialBalance)
        {
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        public void TransferFunds(double amount)
        {
            if (amount > Balance)
            {
                throw new InsufficientFundsException($"Transfer failed! Insufficient balance. Available balance: {Balance}");
            }

            Balance -= amount;
            Console.WriteLine($"Transfer successful! Remaining balance: {Balance}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            try
            {
                BankAccount account = new BankAccount("John Doe", 5000);
                Console.WriteLine("Enter the amount to transfer:");
                double amount = Convert.ToDouble(Console.ReadLine());
                account.TransferFunds(amount);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
