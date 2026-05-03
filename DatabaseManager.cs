// ================================
// Name: kwadwo Owusu
// Date: 03/05/2026
// Assignment: SDC320 - Week 4 Project - Database Interactions
// Purpose: Handles SQLite CRUD operations for the Rolodex application.
// ================================

using System;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace RolodexApp 
{
    public class DatabaseManager
    {
        private string connectionString = "Data Source=Rolodex.db";

        // CONSTRUCTOR: Initializes table if it doesn't exist[cite: 10]
        public DatabaseManager()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Contacts (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        FirstName TEXT,
                        LastName TEXT,
                        Phone TEXT,
                        Email TEXT,
                        Type TEXT,
                        ExtraInfo TEXT
                    );";
                command.ExecuteNonQuery();
            }
        }

        // CREATE: Adds a new record
        public void CreateContact(Contact contact, string type, string extra)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Contacts (FirstName, LastName, Phone, Email, Type, ExtraInfo) VALUES ($f, $l, $p, $e, $t, $ex)";
                command.Parameters.AddWithValue("$f", contact.FirstName);
                command.Parameters.AddWithValue("$l", contact.LastName);
                command.Parameters.AddWithValue("$p", contact.Phone);
                command.Parameters.AddWithValue("$e", contact.Email);
                command.Parameters.AddWithValue("$t", type);
                command.Parameters.AddWithValue("$ex", extra);
                command.ExecuteNonQuery();
            }
        }

        // READ: Displays all records
        public void ReadAllContacts()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Contacts";
                using (var reader = command.ExecuteReader())
                {
                    Console.WriteLine("\n--- Database Records ---");
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader.GetInt32(0)} | {reader.GetString(1)} {reader.GetString(2)} | Type: {reader.GetString(5)}");
                    }
                }
            }
        }

        // UPDATE: Modifies phone number
        public void UpdateContactPhone(int id, string newPhone)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "UPDATE Contacts SET Phone = $phone WHERE Id = $id";
                command.Parameters.AddWithValue("$phone", newPhone);
                command.Parameters.AddWithValue("$id", id);
                command.ExecuteNonQuery();
            }
        }

        // DELETE: Removes a record
        public void DeleteContact(int id)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "DELETE FROM Contacts WHERE Id = $id";
                command.Parameters.AddWithValue("$id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}