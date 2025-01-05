

using ContactManager.Helpers;

namespace ContactManager.Models;

public class Contact
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Number { get; set; }
    public string Address { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;

    public string Id { get; set; }

    public Contact()
    {
        Id = UniqueIdentifierGenerator.Generate();
    }

}
