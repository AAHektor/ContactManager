using ContactManager.Models;
using ContactManager.Services;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace ContactManager.Tests.Services;

public class ContactListService_Tests
{
    [Fact]
    public void ShowContactList_ShouldReturnErrorMsgWhenListIsEmpty()
    {
        var contactFileService = new ContactFileService("empty_contacts.js");
        var contactListService = new ContactListService(contactFileService);

        var sw = new StringWriter();
        Console.SetOut(sw);

        contactListService.ShowContactList();

        var output = sw.ToString().Trim();
        Assert.Equal("No contacts found.", output);
        
    }

    [Fact]
    public void ShowContactList_ShouldReturnErrorMsgWhenFileDoesNotExist()
    {
        var contactFileService = new ContactFileService("non_existent_file.json");
        var contactListService = new ContactListService(contactFileService);

        var sw = new StringWriter();
        Console.SetOut(sw);

        contactListService.ShowContactList();

        var output = sw.ToString().Trim();
        Assert.Equal("No contacts found.", output);
    }

    [Fact]
    /* Detta är genererat av Chat GPT 4o - Denna kod kontrollerar att korrekt kontaktinformation skrivs ut i konsolen när metoden ShowContactList() anropas.
     * Först skapas två testkontakter med värden, sparar dem i en fil, contacts.json. Sedan säkerställer att informationen visas som förväntat. Slutligen tar bort filen.
     */
    public void ShowContactList_ShouldReturnCorrectContactInformation()
    {
        var contacts = new List<Contact>
        {
            new Contact { FirstName = "Peter", LastName = "Petersson", Email = "peter@domain.com", Number = "123", Address = "street", PostalCode = "1234", City = "City", Id = "1" },
            new Contact { FirstName = "Keter", LastName = "Ketersson", Email = "keter@domain.com", Number = "1234", Address = "streett", PostalCode = "12345", City = "Cityy", Id = "2" },
        };

        var filePath = "contacts.json";
        var contactFileService = new ContactFileService(filePath);

        var json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);

        var contactListService = new ContactListService(contactFileService);

        var sw = new StringWriter();
        Console.SetOut(sw);

        contactListService.ShowContactList();

        var output = sw.ToString();
        Assert.Contains("Peter Petersson", output);
        Assert.Contains("keter@domain.com", output);

        if (File.Exists(filePath)) File.Delete(filePath);
    }


}
