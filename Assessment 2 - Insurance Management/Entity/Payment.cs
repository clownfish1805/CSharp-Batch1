using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Entity
{
    public class Payment
    {
        public int PaymentId 
        { 
            get; 
            set; 
        }
        public DateOnly PaymentDate 
        { 
            get; 
            set; 
        }
        public double PaymentAmount 
        { 
            get; 
            set; 
        }
        public int ClientId 
        { 
            get; 
            set; 
        }

        public Payment() { }

        public Payment(int paymentId, DateOnly paymentDate, double paymentAmount, int clientId)
        {
            PaymentId = paymentId;
            PaymentDate = paymentDate;
            PaymentAmount = paymentAmount;
            ClientId = clientId;
        }

        public void Print()
        {
            Console.WriteLine($"PaymentId: {PaymentId}, PaymentDate: {PaymentDate}, Amount: {PaymentAmount}, ClientId: {ClientId}");
        }

    }
}
