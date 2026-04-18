// ============================================================
// Name:    Kwadwo Owusu
// Date:    18/04/2026
// Course:  SDC320K — Week 2 Project
// Purpose: Base class for all contact types. Demonstrates 
//          Inheritance and Interface implementation.
// ============================================================

using System;

namespace RolodexApp
{
    // DEMONSTRATION OF INTERFACE: 
    // This defines a "contract" that all contacts must follow.
    interface IDisplayable
    {
        void ShowSummary();
    }

    // BASE CLASS — implements the IDisplayable interface
    class Contact : IDisplayable
    {
        // Properties used across the application
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string Phone     { get; set; }
        public string Email     { get; set; }
        public string Address   { get; set; }

        // Helper property for search and display logic in Rolodex.cs
        public string FullName => $"{FirstName} {LastName}";

        // Constructor initializing the fields
        public Contact(string firstName, string lastName, string phone, string email, string address)
        {
            FirstName = firstName;
            LastName  = lastName;
            Phone     = phone;
            Email     = email;
            Address   = address;
        }

        // INTERFACE IMPLEMENTATION: Providing a simple summary
        public void ShowSummary()
        {
            Console.WriteLine($"[Summary] {FullName} - {Phone}");
        }

        // DEMONSTRATION OF POLYMORPHISM: 
        // Marked as 'virtual' so derived classes can provide unique versions.
        public virtual void DisplayContact()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"  Name    : {FullName}");
            Console.WriteLine($"  Phone   : {Phone}");
            Console.WriteLine($"  Email   : {Email}");
            Console.WriteLine($"  Address : {Address}");
        }

        // FIX FOR CS0115: Providing the virtual method for child classes to override
        public virtual void UpdateContact()
        {
            Console.Write($"  First Name [{FirstName}]: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input)) FirstName = input;

            Console.Write($"  Last Name [{LastName}]: ");
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input)) LastName = input;

            Console.Write($"  Phone [{Phone}]: ");
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input)) Phone = input;

            Console.Write($"  Email [{Email}]: ");
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input)) Email = input;

            Console.Write($"  Address [{Address}]: ");
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input)) Address = input;
        }

        // Returns the contact type label (also polymorphic)
        public virtual string GetContactType()
        {
            return "General Contact";
        }
    }
}