// ================================
// Name: Kwadwo Owusu
// Date: 05/05/2026
// Description: Updated Week 4 Project with Interactive User Menu
// ================================

using System;

namespace RolodexApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager db = new DatabaseManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- Rolodex Database Menu ---");
                Console.WriteLine("1. Add (Create) Contact");
                Console.WriteLine("2. View (Read) All Contacts");
                Console.WriteLine("3. Update Contact Phone");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option (1-5): ");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        // User input for Create
                        Console.Write("Enter First Name: ");
                        string fName = Console.ReadLine() ?? "";
                        Console.Write("Enter Last Name: ");
                        string lName = Console.ReadLine() ?? "";
                        Console.Write("Enter Phone: ");
                        string phone = Console.ReadLine() ?? "";
                        
                        // Creating a generic contact to store
                        BusinessContact newContact = new BusinessContact(fName, lName, phone, "N/A", "N/A", "N/A");
                        db.CreateContact(newContact, "General", "N/A");
                        Console.WriteLine("Contact Added!");
                        break;

                    case "2":
                        // Read from database
                        db.ReadAllContacts();
                        break;

                    case "3":
                        // User input for Update
                        Console.Write("Enter ID to update: ");
                        int updateId = int.Parse(Console.ReadLine() ?? "0");
                        Console.Write("Enter new phone number: ");
                        string newPhone = Console.ReadLine() ?? "";
                        db.UpdateContactPhone(updateId, newPhone);
                        break;

                    case "4":
                        // User input for Delete
                        Console.Write("Enter ID to delete: ");
                        int deleteId = int.Parse(Console.ReadLine() ?? "0");
                        db.DeleteContact(deleteId);
                        break;

                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }
    }
}