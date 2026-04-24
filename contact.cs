// ================================
// Name: Kwadwo Owusu
// Date: 23/04/2026
// Assignment: SDC320 - Week 3 Project - Abstraction, Constructors & Access Specifiers
// Description: Abstract base class for all contact types.
//              Defines shared properties and enforces abstract methods
//              that all derived classes must implement.
// ================================

using System;

// ABSTRACTION: Contact is abstract - cannot be instantiated directly.
// Forces all derived classes to provide their own DisplayContact() and ShowSummary().
public abstract class Contact
{
    // ACCESS SPECIFIERS: Private backing fields - only accessible within this class
    private string firstName;
    private string lastName;
    private string phone;
    private string email;

    // Public properties - expose data in a controlled way
    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName  { get => lastName;  set => lastName  = value; }
    public string Phone     { get => phone;     set => phone     = value; }
    public string Email     { get => email;     set => email     = value; }

    // CONSTRUCTOR 1: Default constructor
    public Contact()
    {
        firstName = "Unknown";
        lastName  = "Unknown";
        phone     = "N/A";
        email     = "N/A";
    }

    // CONSTRUCTOR 2: Full constructor
    public Contact(string firstName, string lastName, string phone, string email)
    {
        this.firstName = firstName;
        this.lastName  = lastName;
        this.phone     = phone;
        this.email     = email;
    }

    // ABSTRACTION: Abstract methods - derived classes MUST implement these
    public abstract void DisplayContact();
    public abstract void ShowSummary();

    // Protected helper - only accessible by this class and derived classes
    protected string GetFullName() => $"{firstName} {lastName}";

    // ToString override for general use
    public override string ToString() => $"{GetFullName()} | {phone} | {email}";
}