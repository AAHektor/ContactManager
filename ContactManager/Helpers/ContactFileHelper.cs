using ContactManager.Models;
using System.Text.Json;

namespace ContactManager.Helpers;

public static class ContactFileHelper
{
    public static List<Contact> LoadContactsFromFile(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Contact>>(existingJson) ?? new List<Contact>();
            }
            else
            {
                return new List<Contact>();
            }
        }
        catch (JsonException)
        {
            return new List<Contact>();
        }
        catch (Exception)
        {
            return new List<Contact>();
        } 
        
    }
    public static void SaveContactToJsFile(Contact contact, string filePath)
    {
        List<Contact> contacts = LoadContactsFromFile(filePath);
        contacts.Add(contact);

        string json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
        
    }
}
