// ================================
// Name: Kwadwo Owusu
// Date: 03/05/2026
// Assignment: SDC320 - Week 4 Project - Database Interactions
// Description: Demonstrates CRUD operations with SQLite.
// ================================

using System;

namespace RolodexApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager db = new DatabaseManager();

            // Header[cite: 14]
            Console.WriteLine("==========================================");
            Console.WriteLine("  Project Week 4: Database Interactions");
            Console.WriteLine("  Name: Kwadwo owusu");
            Console.WriteLine("==========================================\n");

            // Welcome Message
            Console.WriteLine("Welcome to the Rolodex SQLite System!");
            Console.WriteLine("This application manages contacts in a local database.\n");

            // 1. CREATE[cite: 9, 11]
            Console.WriteLine("[Action] CREATE: Adding James Carter and Akosua Owusu...");
            BusinessContact b1 = new BusinessContact("James", "Carter", "555-1001", "james@tech.com", "TechCorp", "Engineer");
            FamilyContact f1 = new FamilyContact("Akosua", "Owusu", "555-2001", "akosua@gmail.com", "Sister");
            
            db.CreateContact(b1, "Business", b1.Company);
            db.CreateContact(f1, "Family", f1.Relationship);

            // 2. READ
            db.ReadAllContacts();

            // 3. UPDATE
            Console.WriteLine("\n[Action] UPDATE: Changing Phone for Record 1...");
            db.UpdateContactPhone(1, "555-9999");
            db.ReadAllContacts();

            // 4. DELETE
            Console.WriteLine("\n[Action] DELETE: Removing Record 2...");
            db.DeleteContact(2);
            
            // Final View
            Console.WriteLine("\nFinal View:");
            db.ReadAllContacts();

            Console.WriteLine("\n==========================================");
            Console.WriteLine("  Week 4 Submission Complete");
            Console.WriteLine("==========================================");
        }
    }
}