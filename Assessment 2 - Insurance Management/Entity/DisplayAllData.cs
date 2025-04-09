using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insurance.Util;

namespace Insurance.Entity
{
    public class DisplayAllData
    {
        SqlConnection conn = DBConnection.GetConnection();
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            string query = "SELECT * FROM [User]";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                users.Add(new User(
                    (int)reader["userId"],
                    reader["username"].ToString(),
                    reader["password"].ToString(),
                    reader["role"].ToString()
                ));
            }

            reader.Close();
            return users;
        }

        public List<Client> GetAllClients()
        {
            List<Client> clients = new List<Client>();
            string query = "SELECT * FROM Client";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                clients.Add(new Client(
                    (int)reader["clientId"],
                    reader["clientName"].ToString(),
                    reader["contactInfo"].ToString(),
                    (int)reader["policyId"]
                ));
            }

            reader.Close();
            return clients;
        }

        public List<Claim> GetAllClaims()
        {
            List<Claim> claims = new List<Claim>();
            string query = "SELECT * FROM Claim";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                claims.Add(new Claim(
                    (int)reader["claimId"],
                    reader["claimNumber"].ToString(),
                    DateOnly.FromDateTime((DateTime)reader["dateFiled"]),
                    (double)Convert.ToDecimal(reader["claimAmount"]),
                    reader["status"].ToString(),
                    (int)reader["policyId"],
                    (int)reader["clientId"]
                ));
            }

            reader.Close();
            return claims;
        }


        public List<Payment> GetAllPayments()
        {
            List<Payment> payments = new List<Payment>();
            string query = "SELECT * FROM Payment";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                payments.Add(new Payment(
                    (int)reader["paymentId"],
                    DateOnly.FromDateTime((DateTime)reader["paymentDate"]),
                    (double)Convert.ToDecimal(reader["paymentAmount"]),
                    (int)reader["clientId"]
                ));
            }

            reader.Close();
            return payments;
        }
    }
}
