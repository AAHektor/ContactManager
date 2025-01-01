namespace ContactManager.Services;

public class QuitProgramService
{
    public void ShowQuitProgram()
    {
        Console.Write("Do you want to exit this application (y/n): ");
        var option = Console.ReadLine()!;

        if (option.ToLower() == "y")
        {
            Environment.Exit(0);
        }


    }
}
