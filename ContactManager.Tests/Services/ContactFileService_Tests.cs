namespace ContactManager.Tests.Services;

using ContactManager.Models;
using ContactManager.Services;

public class ContactFileService_Tests
{
    [Fact]
    public void ContactFileService_ShouldReturnCorrectFilePath()
    {
        var filePath = "contacts_test.json";
        var contactFileService = new ContactFileService(filePath);

        Assert.Equal(filePath, contactFileService.FilePath);
    }

    [Fact]
    /* Detta är genererat av Chat GPT 4o - Denna kod kontrollerar att LoadContacts() fungerar och returnerar en lista med kontakter. 
     * Den kontrollerar att listan inte är null och att den är av rätt typ (List<Contact>).
    */
    public void LoadContacts_ShouldReturnListOfContacts()
    {
        var filePath = "contacts_test.json";
        var contactFileService = new ContactFileService(filePath);

        var contacts = contactFileService.LoadContacts();

        Assert.NotNull(contacts);
        Assert.IsType<List<Contact>>(contacts);
    }

    [Fact]
    public void LoadContacts_ShouldReturnEmptyList_IfFileDoesNotExist()
    {
        var filePath = "nonexistent_contacts.json";
        var contactFileService = new ContactFileService(filePath);

        var contacts = contactFileService.LoadContacts();

        Assert.NotNull(contacts);
        Assert.Empty(contacts);
    }


}
