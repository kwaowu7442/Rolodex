// ================================
// Name: Kwadwo Owusu
// Date: 23/04/2026
// Assignment: SDC320 - Week 3 Project - Abstraction, Constructors & Access Specifiers
// Description: Derived class representing a business contact.
//              Inherits from Contact and adds Company and JobTitle.
//              Implements all abstract methods from the base class.
// ================================

using System;

public class BusinessContact : Contact, IDisplayable
{
    // ACCESS SPECIFIER: Private - only used inside this class
    private string company;
    private string jobTitle;

    // Public properties for controlled access
    public string Company  { get => company;  set => company  = value; }
    public string JobTitle { get => jobTitle; set => jobTitle = value; }

    // CONSTRUCTOR 1: Default constructor
    public BusinessContact() : base()
    {
        company  = "Unknown Company";
        jobTitle = "Unknown Title";
    }

    // CONSTRUCTOR 2: Full constructor
    public BusinessContact(string firstName, string lastName, string phone,
                           string email, string company, string jobTitle)
        : base(firstName, lastName, phone, email)
    {
        this.company  = company;
        this.jobTitle = jobTitle;
    }

    // ABSTRACTION: Implementing the abstract method from Contact
    public override void DisplayContact()
    {
        Console.WriteLine($"[Business Contact]");
        Console.WriteLine($"  Name     : {GetFullName()}");
        Console.WriteLine($"  Company  : {company}");
        Console.WriteLine($"  Job Title: {jobTitle}");
        Console.WriteLine($"  Phone    : {Phone}");
        Console.WriteLine($"  Email    : {Email}");
    }

    // Implementing ShowSummary from IDisplayable interface
    public override void ShowSummary()
    {
        Console.WriteLine($"Business - {GetFullName()} @ {company} ({jobTitle})");
    }
}