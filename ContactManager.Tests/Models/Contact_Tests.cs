
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

    [Fact]
    /*
     Detta är genererat av Chat GPT 4o - Denna kod gör att egenskaperna kan tilldelas och läsas in korrekt. 
     */
    public void Contact_ShouldAllowPropertyAssignment()
    {
        var contact = new Contact
        {
            FirstName = "Peter",
            LastName = "Petersson",
            Email = "peter@domain.com",
            Number = "123",
            Address = "street",
            PostalCode = "1234",
            City = "City"
        };

        Assert.Equal("Peter", contact.FirstName);
        Assert.Equal("Petersson", contact.LastName);
        Assert.Equal("peter@domain.com", contact.Email);
        Assert.Equal("123", contact.Number);
        Assert.Equal("street", contact.Address);
        Assert.Equal("1234", contact.PostalCode);
        Assert.Equal("City", contact.City);
    }

    [Fact]
    public void Contact_TwoInstancesShouldHaveDifferentIds()
    {
        var firstContact = new Contact();
        var secondContact = new Contact();

        Assert.NotEqual(firstContact.Id, secondContact.Id);
    }

}
