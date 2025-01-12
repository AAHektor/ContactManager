using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using ContactManager.Helpers;
using ContactManager.Models;
namespace ContactManager.Tests.Helpers;

public class ContactFileHelper_Tests
{
    [Fact]
    /* Detta är genererat av Chat GPT 4o - Denna kod kontrollerar att en kontakt sparas korrekt i en fil.
     * först skapas en testkontakt som sparas i filen. Därefter kontrollerar den att filen skapades och att
     * kontaktinformationen sparades korrekt. Slutligen tar den bort testfilen. 
     */
    public void SaveContactToFile_ShouldSaveContactCorrectly()
    {
        //Arrange
        string testFilePath = "test_contacts.json";
        var contact = new Contact
        {
            FirstName = "Peter",
            LastName = "Petersson",
            Email = "peter@domain.com",
            Number = "1234567890",
            Address = "gatan 1c",
            PostalCode = "123456",
            City = "City",

        };
        //Act
        ContactFileHelper.SaveContactToJsFile(contact, testFilePath);

        //Assert
        Assert.True(File.Exists(testFilePath), "The contact file was not created.");

        string json = File.ReadAllText(testFilePath);
        var contacts = JsonSerializer.Deserialize<List<Contact>>(json);

        Assert.NotNull(contacts);
        Assert.Single(contacts);
        Assert.Equal("Peter", contacts[0].FirstName);
        Assert.Equal("Petersson", contacts[0].LastName);
        Assert.Equal("peter@domain.com", contacts[0].Email);

        if (File.Exists(testFilePath))
        {
            File.Delete(testFilePath);
        }
    }

    [Fact]
    public void LoadContactToFile_ShouldReturnEmptyList_WhenFileDoesNotExist()
    {
        string testFilePath = "nonexistent_contacts.json";

        var contacts = ContactFileHelper.LoadContactsFromFile(testFilePath);

        Assert.NotNull(contacts);
        Assert.Empty(contacts);
    }

    [Fact]
    public void LoadContactsFromFile_ShouldReturnEmptyList_WhenFileHasInvalidJson()
    {
        string testFilePath = "invalid_contacts.json";
        File.WriteAllText(testFilePath, "{ invalid json }");

        var contacts = ContactFileHelper.LoadContactsFromFile(testFilePath);

        Assert.NotNull(contacts);
        Assert.Empty(contacts);

        if (File.Exists(testFilePath))
        {
            File.Delete(testFilePath);
        }
    }
}
