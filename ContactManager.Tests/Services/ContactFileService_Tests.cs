namespace ContactManager.Tests.Services;
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
}
