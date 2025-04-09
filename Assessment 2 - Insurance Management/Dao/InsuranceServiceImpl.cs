using Insurance.Entity;

using Insurance.Exceptions;
using Insurance.Util;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;

namespace Insurance.Dao
{
    public class InsuranceServiceImpl : IPolicyService
    {
        SqlConnection conn = DBConnection.GetConnection();

        public bool CreatePolicy(Policy policy)
        {
            string query = "INSERT INTO Policy (policyName) VALUES (@name)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", policy.PolicyName);
            return cmd.ExecuteNonQuery() > 0;
        }

        public Policy GetPolicy(int policyId)
        {
            string query = "SELECT * FROM Policy WHERE policyId = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", policyId);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Policy policyValues = new Policy((int)reader["policyId"], "Policy name: "+ reader["policyName"].ToString());
                reader.Close();
                return policyValues;
            }
            reader.Close();
            throw new PolicyNotfoundException("Policy ID not found.");
        }

        public List<Policy> GetAllPolicies()
        {
            List<Policy> list = new List<Policy>();
            string query = "SELECT * FROM Policy";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Policy((int)reader["policyId"], reader["policyName"].ToString()));
            }

            reader.Close();
            return list;
        }

        public bool UpdatePolicy(Policy policy)
        {
            string query = "UPDATE Policy SET policyName = @name WHERE policyId = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", policy.PolicyName);
            cmd.Parameters.AddWithValue("@id", policy.PolicyId);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool DeletePolicy(int policyId)
        {
            string checkQuery = "SELECT COUNT(*) FROM Client WHERE policyId = @id";
            SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@id", policyId);
            int count = (int)checkCmd.ExecuteScalar();

            if (count > 0)
            {
                Console.WriteLine("Cannot delete policy. It is assigned to one or more clients.");
                return false;
            }

            string query = "DELETE FROM Policy WHERE policyId = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", policyId);
            return cmd.ExecuteNonQuery() > 0;

        }
    }
}
