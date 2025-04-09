using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Entity
{
    public class Policy
    {
        public int PolicyId 
        { 
            get; 
            set; 
        }
        public string PolicyName 
        { 
            get; 
            set; 
        }

        public Policy() { }

        public Policy(int policyId, string policyName)
        {
            PolicyId = policyId;
            PolicyName = policyName;
        }
        public void Print()
        {
            Console.WriteLine($"PolicyId: {PolicyId}, PolicyName: {PolicyName}");
        }
    }
}
