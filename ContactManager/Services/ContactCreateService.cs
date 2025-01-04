
using ContactManager.Models;
using System.Text.Json;

namespace ContactManager.Services;

public class ContactCreateService
{

    private const string FilePath = "contacts.json";
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

        SaveContactToFile(newContact);
        Console.WriteLine("\nContact successfully created.");

    }

    private void SaveContactToFile(Contact contact)
    {
        List<Contact> contacts;
        if (File.Exists(FilePath))
        {
            string existingJson = File.ReadAllText(FilePath);
            contacts = JsonSerializer.Deserialize<List<Contact>>(existingJson) ?? new List<Contact>();
        }
        else
        {
            contacts = new List<Contact>();
        }

        contacts.Add(contact);

        string json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(FilePath, json);
    }
}
