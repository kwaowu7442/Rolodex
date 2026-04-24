// ================================
// Name: Kwadwo Owusu
// Date: 23/04/2026
// Assignment: SDC320 - Week 3 Project - Abstraction, Constructors & Access Specifiers
// Description: Derived class representing a family contact.
//              Inherits from Contact and adds Relationship field.
//              Implements all abstract methods from the base class.
// ================================

using System;

public class FamilyContact : Contact, IDisplayable
{
    // ACCESS SPECIFIER: Private - only used inside this class
    private string relationship;

    public string Relationship { get => relationship; set => relationship = value; }

    // CONSTRUCTOR 1: Default constructor
    public FamilyContact() : base()
    {
        relationship = "Unknown";
    }

    // CONSTRUCTOR 2: Full constructor
    public FamilyContact(string firstName, string lastName, string phone,
                         string email, string relationship)
        : base(firstName, lastName, phone, email)
    {
        this.relationship = relationship;
    }

    // ABSTRACTION: Implementing the abstract method from Contact
    public override void DisplayContact()
    {
        Console.WriteLine($"[Family Contact]");
        Console.WriteLine($"  Name        : {GetFullName()}");
        Console.WriteLine($"  Relationship: {relationship}");
        Console.WriteLine($"  Phone       : {Phone}");
        Console.WriteLine($"  Email       : {Email}");
    }

    public override void ShowSummary()
    {
        Console.WriteLine($"Family - {GetFullName()} ({relationship})");
    }
}