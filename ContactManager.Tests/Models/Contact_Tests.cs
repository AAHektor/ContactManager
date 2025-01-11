
namespace ContactManager.Tests.Models;
using ContactManager.Models;

public class Contact_Tests
{
    [Fact]
    public void Contact_ShouldGenerateUniqueId()
    {
        var contact = new Contact();

        contact.FirstName = "Peter";
        contact.LastName = "Petersson";
        contact.Email = "peter@domain.com";
        contact.Number = "123";
        contact.Address = "street";
        contact.PostalCode = "1234";
        contact.City = "City";

        Assert.False(string.IsNullOrEmpty(contact.Id));
    }

}
