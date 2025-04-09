﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Entity
{
    public class Client
    {
        public int ClientId 
        { 
            get; 
            set; 
        }
        public string ClientName 
        { 
            get; 
            set; 
        }
        public string ContactInfo 
        { 
            get; 
            set; 
        }
        public int PolicyId 
        { 
            get; 
            set; 
        }

        public Client() { }

        public Client(int clientId, string clientName, string contactInfo, int policyId)
        {
            ClientId = clientId;
            ClientName = clientName;
            ContactInfo = contactInfo;
            PolicyId = policyId;
        }

        public void Print()
        {
            Console.WriteLine($"ClientId: {ClientId}, Name: {ClientName}, Contact: {ContactInfo}, PolicyId: {PolicyId}");
        }
    }
}
