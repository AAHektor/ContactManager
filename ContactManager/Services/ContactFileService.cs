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

    /* Detta är genererat av Chat GPT 4o - Denna kod använder ContactFileHelper för att läsa in kontakter från filen som är angiven av _filePath.
     * Som returnerar en lista med kontakter eller en tom lista om något går fel.
     */
    public List<Contact>? LoadContacts()
    {
        return ContactFileHelper.LoadContactsFromFile(_filePath);
    }

    /* Detta är genererat av Chat GPT 4o - Denna kod gör det möjligt att få tillgång till filens sökväg utanför klassen */
    public string FilePath => _filePath;
}
