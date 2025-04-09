using Insurance.Entity;
using Insurance.Main;

namespace Insurance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DisplayAllData display=new DisplayAllData();
            var payments = display.GetAllPayments();
            Console.WriteLine("\nPayments table");
            foreach (var payment in payments)
            {
                Console.WriteLine($"{payment.PaymentId} | {payment.PaymentDate} | {payment.PaymentAmount} | {payment.ClientId}");
            }

            var claims = display.GetAllClaims();

            Console.WriteLine("\nClaims table");
            foreach (var claim in claims)
            {
                Console.WriteLine($"{claim.ClaimId} | {claim.ClaimNumber} | {claim.DateFiled} | {claim.ClaimAmount} | {claim.Status} | {claim.PolicyId} | {claim.ClientId}");
            }

            var clients = display.GetAllClients();

            Console.WriteLine("\nClients table");
            foreach (var client in clients)
            {
                Console.WriteLine($"{client.ClientId} | {client.ClientName} | {client.ContactInfo} | {client.PolicyId}");
            }

            var users = display.GetAllUsers();

            Console.WriteLine("\nUsers table");
            foreach (var user in users)
            {
                Console.WriteLine($"{user.UserId} | {user.Username} | {user.Password} | {user.Role}");
            }

            Mainmodule mainmodule = new Mainmodule();
            mainmodule.runAll();
        }
    }
}



