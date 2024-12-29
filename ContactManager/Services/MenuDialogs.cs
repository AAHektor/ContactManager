namespace ContactManager.Services;

public class MenuDialogs
{
    public void CreateUserDialog()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Welcome to ContactManager\n");
            Console.WriteLine("1. Contacts");
            Console.WriteLine("2. Create Contact");
            Console.WriteLine("3. Exit Program");
            Console.WriteLine();

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ContactList();
                    break;

                case "2":
                    ContactCreate();
                    break;

                case "3":
                    running = false;
                    break;

                default:
                    Console.WriteLine("invalid option.");
                    break;
            }
        }
    }

}
