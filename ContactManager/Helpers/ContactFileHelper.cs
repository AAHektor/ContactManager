using ContactManager.Models;
using System.Text.Json;

namespace ContactManager.Helpers;

public static class ContactFileHelper
{
    /* Detta är genererat av Chat GPT 4o - Denna kod försöker läsa en fil för att få en lista med kontakter.
     * Om filen finns läser den innehållet och försöker omvandla det till en lista med kontakter. 
     * Om filen inte finns eller om något blir fel så returnerar den en tom lista. 
     */
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

    /* Detta är genererat av Chat GPT 4o - Denna kod lägger till en ny kontakt i filen. Först läser den in kontakterna som finns i filen
     * sedan lägger den till den nya kontakten. Slutligen sparar den hela listan med kontakter till filen så att den nya kontakten följer med. 
     */
    public static void SaveContactToJsFile(Contact contact, string filePath)
    {
        List<Contact> contacts = LoadContactsFromFile(filePath);
        contacts.Add(contact);

        string json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
        
    }
}
