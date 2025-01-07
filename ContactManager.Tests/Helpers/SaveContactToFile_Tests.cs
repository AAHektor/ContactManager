using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using ContactManager.Helpers;
using ContactManager.Models;
namespace ContactManager.Tests.Helpers;

public class SaveContactToFile_Tests
{
    [Fact]
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
        SaveContactToFile.SaveContactToJsFile(contact, testFilePath);

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
}
