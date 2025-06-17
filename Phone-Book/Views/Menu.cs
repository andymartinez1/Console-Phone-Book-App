using Phone_Book.Models;
using Phone_Book.Services;
using Spectre.Console;

namespace Phone_Book.Views;

public class Menu
{
    internal static void MainMenu()
    {
        var isRunning = true;
        while (isRunning)
        {
            AnsiConsole.Write(new FigletText("Phone Book").Color(Color.Aqua));

            var userChoice = AnsiConsole.Prompt(
                new SelectionPrompt<Enums.MenuOptions>()
                    .Title("What would you like to do?")
                    .AddChoices(
                        Enums.MenuOptions.AddContact,
                        Enums.MenuOptions.ViewContact,
                        Enums.MenuOptions.ViewAllContacts,
                        Enums.MenuOptions.EditContact,
                        Enums.MenuOptions.DeleteContact,
                        Enums.MenuOptions.Quit
                    )
            );

            switch (userChoice)
            {
                case Enums.MenuOptions.AddContact:
                    AnsiConsole.Clear();
                    ContactService.InsertContact();
                    break;
                case Enums.MenuOptions.ViewContact:
                    AnsiConsole.Clear();
                    ContactService.GetContactById();
                    break;
                case Enums.MenuOptions.ViewAllContacts:
                    AnsiConsole.Clear();
                    ContactService.GetAllContacts();
                    break;
                case Enums.MenuOptions.EditContact:
                    AnsiConsole.Clear();
                    ContactService.UpdateContact();
                    break;
                case Enums.MenuOptions.DeleteContact:
                    AnsiConsole.Clear();
                    ContactService.DeleteContact();
                    break;
                case Enums.MenuOptions.Quit:
                    AnsiConsole.WriteLine("Goodbye");
                    isRunning = false;
                    break;
                default:
                    AnsiConsole.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }
}
