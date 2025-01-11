using ContactManager.Models;
using ContactManager.Helpers;

namespace ContactManager.Services;

public class ContactFileService
{
    private readonly string _filePath;

    public ContactFileService(string filePath)
    {
        _filePath = filePath;
    }

    public List<Contact>? LoadContacts()
    {
        return ContactFileHelper.LoadContactsFromFile(_filePath);
    }
}
