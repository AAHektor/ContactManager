using System.Text.Json;
using ContactManager.Helpers;
using ContactManager.Models;

namespace ContactManager.Services;

public class ContactListService
{
    private readonly ContactFileService _contactFileService;

    public ContactListService(ContactFileService contactFileService)
    {
        _contactFileService = contactFileService;
    }

    public void ShowContactList()
    {
        try
        {

            List<Contact>? contacts = _contactFileService.LoadContacts();

            if (contacts == null || contacts.Count == 0)
            {
                Console.WriteLine("No contacts found. ");
                return;
            }

            Console.WriteLine("CONTACTS:");
            Console.WriteLine(new string('-', 40));
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}");
                Console.WriteLine($"Email: {contact.Email}");
                Console.WriteLine($"Number: {contact.Number}");
                Console.WriteLine($"Address: {contact.Address}, {contact.PostalCode} {contact.City}");
                Console.WriteLine($"ID: {contact.Id}");
                Console.WriteLine(new string('-', 40));

            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred {ex.Message}");
        }

        Console.ReadKey();
    }
}
