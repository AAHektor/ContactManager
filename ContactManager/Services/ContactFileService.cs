using ContactManager.Models;
using ContactManager.Helpers;

namespace ContactManager.Services;

public class ContactFileService
{
    private readonly string _filePath = "contacts.json";

    public List<Contact>? LoadContacts()
    {
        return ContactFileHelper.LoadContactsFromFile(_filePath);
    }
}
