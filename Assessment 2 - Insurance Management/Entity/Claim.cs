using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Entity
{
    public class Claim
    {
        public int ClaimId 
        { 
            get; 
            set; 
        }
        public string ClaimNumber 
        { 
            get; 
            set; 
        }
        public DateOnly DateFiled 
        { 
            get; 
            set; 
        }
        public double ClaimAmount 
        { 
            get; 
            set; 
        }
        public string Status 
        { 
            get; 
            set; 
        }
        public int PolicyId
        { 
            get; 
            set; 
        }
        public int ClientId 
        { 
            get; 
            set; 
        }

        public Claim() { }

        public Claim(int claimId, string claimNumber, DateOnly dateFiled, double claimAmount, string status, int policyId, int clientId)
        {
            ClaimId = claimId;
            ClaimNumber = claimNumber;
            DateFiled = dateFiled;
            ClaimAmount = claimAmount;
            Status = status;
            PolicyId = policyId;
            ClientId = clientId;
        }

        public void Print()
        {
            Console.WriteLine($"ClaimId: {ClaimId}, ClaimNumber: {ClaimNumber}, DateFiled: {DateFiled}, Amount: {ClaimAmount}, Status: {Status}, PolicyId: {PolicyId}, ClientId: {ClientId}");
        }
    }
}
