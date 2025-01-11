namespace ContactManager.Services;

public class MenuDialogs
{
    public void CreateUserDialog()
    {
        var contactFileService = new ContactFileService("contacts.json");
        var showContacts = new ContactListService(contactFileService);
        var showContactCreate = new ContactCreateService();
        var quitProgam = new QuitProgramService();

        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Welcome to ContactManager\n");
            Console.WriteLine("1. CONTACTS.");
            Console.WriteLine("2. ADD NEW CONTACT.");
            Console.WriteLine("3. EXIT APPLICATION.");
            Console.WriteLine();

            var option = Console.ReadLine()!;

            

            switch (option.ToLower())
            {
                case "1":
                    Console.Clear();
                    showContacts.ShowContactList();
                    Console.ReadKey();
                    break;

                case "2":
                    Console.Clear();
                    showContactCreate.ShowContactCreate();
                    break;

                case "3":
                    quitProgam.ShowQuitProgram();
                    break;

                default:
                    Console.WriteLine("invalid option.");
                    break;
            }
        }
    }

}
