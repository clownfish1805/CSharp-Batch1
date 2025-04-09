using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insurance.Dao;
using Insurance.Entity;
using Insurance.Exceptions;

namespace Insurance.Main
{
    class Mainmodule
    {
        public void runAll()
        {
            IPolicyService service = new InsuranceServiceImpl();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n=== Insurance Policy Management ===");
                Console.WriteLine("1. Create Policy");
                Console.WriteLine("2. Get Policy by ID");
                Console.WriteLine("3. Get All Policies");
                Console.WriteLine("4. Update Policy");
                Console.WriteLine("5. Delete Policy");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Policy Name: ");
                        string newName = Console.ReadLine();
                        Policy newPolicy = new Policy(0, newName);
                        bool created = service.CreatePolicy(newPolicy);
                        Console.WriteLine(created ? "Policy created successfully." : "Failed to create policy.");
                        break;

                    case "2":
                        Console.Write("Enter Policy ID: ");
                        int getId = int.Parse(Console.ReadLine());
                        try
                        {
                            Policy fetchedPolicy = service.GetPolicy(getId);
                            Console.WriteLine($"Policy ID: {fetchedPolicy.PolicyId}, Name: {fetchedPolicy.PolicyName}");
                        }
                        catch (PolicyNotfoundException ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;

                    case "3":
                        List<Policy> policies = service.GetAllPolicies();
                        if (policies.Count == 0)
                        {
                            Console.WriteLine("No policies found.");
                        }
                        else
                        {
                            foreach (var p in policies)
                            {
                                Console.WriteLine($"Policy ID: {p.PolicyId}, Name: {p.PolicyName}");
                            }
                        }
                        break;

                    case "4":
                        Console.Write("Enter Policy ID to Update: ");
                        int updateId = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Policy Name: ");
                        string updateName = Console.ReadLine();
                        try
                        {
                            Policy updatePolicy = new Policy(updateId, updateName);
                            bool updated = service.UpdatePolicy(updatePolicy);
                            Console.WriteLine(updated ? "Policy updated successfully." : "Update failed.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;

                    case "5":
                        Console.Write("Enter Policy ID to Delete: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        bool deleted = service.DeletePolicy(deleteId);
                        Console.WriteLine(deleted ? "Policy deleted successfully." : "Delete failed.");
                        break;

                    case "6":
                        exit = true;
                        Console.WriteLine("Exiting program.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
