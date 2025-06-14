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
            AnsiConsole.Write(new FigletText("Phone Book")
                .Color(Color.Aqua));

            var userChoice = AnsiConsole.Prompt(
                new SelectionPrompt<MenuOptions>()
                    .Title("What would you like to do?")
                    .AddChoices(
                        MenuOptions.AddContact,
                        MenuOptions.ViewContact,
                        MenuOptions.ViewAllContacts,
                        MenuOptions.EditContact,
                        MenuOptions.DeleteContact,
                        MenuOptions.Quit));

            switch (userChoice)
            {
                case MenuOptions.AddContact:
                    AnsiConsole.Clear();
                    ContactService.InsertContact();
                    break;
                case MenuOptions.ViewContact:
                    AnsiConsole.Clear();
                    ContactService.GetContactById();
                    break;
                case MenuOptions.ViewAllContacts:
                    AnsiConsole.Clear();
                    ContactService.GetAllContacts();
                    break;
                case MenuOptions.EditContact:
                    AnsiConsole.Clear();
                    ContactService.UpdateContact();
                    break;
                case MenuOptions.DeleteContact:
                    AnsiConsole.Clear();
                    ContactService.DeleteContact();
                    break;
                case MenuOptions.Quit:
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