// ================================
// Name: Kwadwo Owusu
// Date: 23/04/2026
// Assignment: SDC320 - Week 3 Project - Abstraction, Constructors & Access Specifiers
// Description: Main entry point. Demonstrates abstraction, constructors,
//              access specifiers, inheritance, and polymorphism using
//              the Rolodex contact management application.
// ================================

using System;

class Program
{
    static void Main(string[] args)
    {
        // Header
        Console.WriteLine("==========================================");
        Console.WriteLine("  Kwadwo Owusu - Week 3 Project");
        Console.WriteLine("  Rolodex - Abstraction, Constructors");
        Console.WriteLine("  & Access Specifiers Demo");
        Console.WriteLine("==========================================\n");

        // Welcome message
        Console.WriteLine("Welcome to the Rolodex Application!");
        Console.WriteLine("This app manages Business, Family, and Friend contacts.");
        Console.WriteLine("Each contact type has its own display format.\n");

        // Create Rolodex
        Rolodex rolodex = new Rolodex();

        // CONSTRUCTORS: Using full constructors with realistic data
        BusinessContact b1 = new BusinessContact("James", "Carter",
            "555-1001", "james.carter@techcorp.com", "TechCorp Inc.", "Software Engineer");

        BusinessContact b2 = new BusinessContact("Linda", "Mensah",
            "555-1002", "linda.mensah@bizgroup.com", "BizGroup Ltd.", "Project Manager");

        FamilyContact f1 = new FamilyContact("Akosua", "Owusu",
            "555-2001", "akosua@gmail.com", "Sister");

        FamilyContact f2 = new FamilyContact("Kwame", "Owusu",
            "555-2002", "kwame@gmail.com", "Father");

        FriendContact fr1 = new FriendContact("Derek", "Boateng",
            "555-3001", "derek.b@gmail.com", "D-Boat");

        FriendContact fr2 = new FriendContact("Ama", "Asante",
            "555-3002", "ama.asante@gmail.com", "Ama");

        // Add all contacts to Rolodex
        rolodex.AddContact(b1);
        rolodex.AddContact(b2);
        rolodex.AddContact(f1);
        rolodex.AddContact(f2);
        rolodex.AddContact(fr1);
        rolodex.AddContact(fr2);

        // Display full details
        rolodex.DisplayAll();

        // Display summaries
        rolodex.DisplaySummaries();

        // Display total count
        rolodex.PrintContactCount();

        Console.WriteLine("\n==========================================");
        Console.WriteLine("  End of Rolodex Demo");
        Console.WriteLine("==========================================");
    }
}