// ================================
// Name: Kwadwo Owusu
// Date: 23/04/2026
// Assignment: SDC320 - Week 3 Project - Abstraction, Constructors & Access Specifiers
// Description: Derived class representing a friend contact.
//              Inherits from Contact and adds Nickname field.
//              Implements all abstract methods from the base class.
// ================================

using System;

public class FriendContact : Contact, IDisplayable
{
    // ACCESS SPECIFIER: Private - only used inside this class
    private string nickname;

    public string Nickname { get => nickname; set => nickname = value; }

    // CONSTRUCTOR 1: Default constructor
    public FriendContact() : base()
    {
        nickname = "N/A";
    }

    // CONSTRUCTOR 2: Full constructor
    public FriendContact(string firstName, string lastName, string phone,
                         string email, string nickname)
        : base(firstName, lastName, phone, email)
    {
        this.nickname = nickname;
    }

    // ABSTRACTION: Implementing the abstract method from Contact
    public override void DisplayContact()
    {
        Console.WriteLine($"[Friend Contact]");
        Console.WriteLine($"  Name    : {GetFullName()}");
        Console.WriteLine($"  Nickname: {nickname}");
        Console.WriteLine($"  Phone   : {Phone}");
        Console.WriteLine($"  Email   : {Email}");
    }

    public override void ShowSummary()
    {
        Console.WriteLine($"Friend - {GetFullName()} aka \"{nickname}\"");
    }
}