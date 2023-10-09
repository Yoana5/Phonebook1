using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Security.Cryptography;
using System.Linq.Expressions;

class Phonebook
{

    static void Main(string[] args)
    {

        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        bool app = true;

        while (app)
        {

            Console.WriteLine("\nPhonebook Application");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Search Contact");
            Console.WriteLine("3. Delete Contact");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {

                case "1":
                    Add(phonebook);
                    break;

                case "2":
                    Search(phonebook);
                    break;

                case "3":
                    Delete(phonebook);
                    break;

                case "4":
                    app = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void Add(Dictionary<string, string> phonebook)
    {

        Console.Write("Enter the name of the contact: ");
        string name = Console.ReadLine();

        if (!phonebook.ContainsKey(name))
        {
            Console.Write("Enter the phone number: ");
            string number = Console.ReadLine();
            phonebook.Add(name, number);
            Console.WriteLine("The contact was added to the phonebook.");
        }
        else
            Console.WriteLine("A contact with this name already exists in the phonebook.");
    }

    static void Search(Dictionary<string, string> phonebook)
    {

        Console.Write("Enter the name of the contact: ");
        string name = Console.ReadLine();

        if (phonebook.ContainsKey(name))
        {
            string number = phonebook[name];
            Console.WriteLine($"Contact: {name}, Phone number: {number}");
        }
        else
            Console.WriteLine("The contact wasn't found in the phonebook.");
    }

    static void Delete(Dictionary<string, string> phonebook)
    {

        Console.Write("Enter the name of the contact: ");
        string name = Console.ReadLine();

        if (phonebook.ContainsKey(name))
        {
            phonebook.Remove(name);
            Console.WriteLine("The contact was deleted from the phonebook.");
        }
        else
            Console.WriteLine("The contact wasn't found in the phonebook.");
    }
}