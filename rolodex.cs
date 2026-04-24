// ================================
// Name: Kwadwo Owusu
// Date: 23/04/2026
// Assignment: SDC320 - Week 3 Project - Abstraction, Constructors & Access Specifiers
// Description: Manages a collection of Contact objects.
//              Demonstrates polymorphism by storing all contact types
//              under the abstract Contact base class reference.
// ================================

using System;
using System.Collections.Generic;

public class Rolodex
{
    // ACCESS SPECIFIER: Private list - only this class manages the contacts
    private List<Contact> contacts;

    // Constructor
    public Rolodex()
    {
        contacts = new List<Contact>();
    }

    // Public method - needed outside the class to add contacts
    public void AddContact(Contact contact)
    {
        contacts.Add(contact);
    }

    // Public method - displays all contacts using POLYMORPHISM
    public void DisplayAll()
    {
        Console.WriteLine("\n========== All Contacts ==========\n");
        // POLYMORPHISM: Each contact's own DisplayContact() is called at runtime
        foreach (Contact c in contacts)
        {
            c.DisplayContact();
            Console.WriteLine();
        }
    }

    // Public method - displays short summaries
    public void DisplaySummaries()
    {
        Console.WriteLine("\n========== Contact Summaries ==========\n");
        foreach (Contact c in contacts)
        {
            c.ShowSummary();
        }
    }

    // Private helper - only used internally
    private int GetContactCount() => contacts.Count;

    public void PrintContactCount()
    {
        Console.WriteLine($"\nTotal Contacts in Rolodex: {GetContactCount()}");
    }
}