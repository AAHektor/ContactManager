namespace ContactManager.Services;

public class MenuDialogs
{
    public void CreateUserDialog()
    {
        var ShowContacts = new ContactListService();
        var ShowContactCreate = new ContactCreateService();
        var QuitProgam = new QuitProgramService();

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
                    ShowContacts.ShowContactList();
                    Console.ReadKey();
                    break;

                case "2":
                    Console.Clear();
                    ShowContactCreate.ShowContactCreate();
                    break;

                case "3":
                    QuitProgam.ShowQuitProgram();
                    break;

                default:
                    Console.WriteLine("invalid option.");
                    break;
            }
        }
    }

}
