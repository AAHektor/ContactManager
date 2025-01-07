using ContactManager.Models;
using System.Text.Json;

namespace ContactManager.Helpers;

public static class SaveContactToFile
{
    private const string FilePath = "contacts.json";
    public static void SaveContactToJsFile(Contact contact, string filePath)
    {
        List<Contact> contacts;
        if (File.Exists(filePath))
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
        File.WriteAllText(filePath, json);
    }
}
