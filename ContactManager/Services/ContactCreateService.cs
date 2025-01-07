
using ContactManager.Models;
using System.Text.Json;
using ContactManager.Helpers;

namespace ContactManager.Services;

public class ContactCreateService
{
    public void ShowContactCreate()
    {

        var newContact = new Contact();

        Console.Write("Enter name: ");
        newContact.FirstName = Console.ReadLine()!;

        Console.Write("Enter lastname: ");
        newContact.LastName = Console.ReadLine()!;

        Console.Write("Enter email: ");
        newContact.Email = Console.ReadLine()!;

        Console.Write("Enter number: ");
        newContact.Number = Console.ReadLine()!;

        Console.Write("Enter address: ");
        newContact.Address = Console.ReadLine()!;

        Console.Write("Enter postal code: ");
        newContact.PostalCode = Console.ReadLine()!;

        Console.Write("Enter city: ");
        newContact.City = Console.ReadLine()!;

        SaveContactToFile.SaveContactToJsFile(newContact, "contacts.json");

        Console.WriteLine("\nContact successfully created.");

        Console.ReadKey();

    }
}
