﻿using Phone_Book.Models;
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
                new SelectionPrompt<Enums.MainMenuOptions>()
                    .Title("What would you like to do?")
                    .AddChoices(
                        Enums.MainMenuOptions.ManageCategories,
                        Enums.MainMenuOptions.ManageContacts,
                        Enums.MainMenuOptions.Quit
                    )
            );
            switch (userChoice)
            {
                case Enums.MainMenuOptions.ManageCategories:
                    AnsiConsole.Clear();
                    CategoryMenu();
                    break;
                case Enums.MainMenuOptions.ManageContacts:
                    AnsiConsole.Clear();
                    ContactMenu();
                    break;
                case Enums.MainMenuOptions.Quit:
                    AnsiConsole.WriteLine("Goodbye");
                    isRunning = false;
                    break;
                default:
                    AnsiConsole.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }

    private static void CategoryMenu()
    {
        var isRunning = true;
        while (isRunning)
        {
            var userChoice = AnsiConsole.Prompt(
                new SelectionPrompt<Enums.CategoryMenuOptions>()
                    .Title("What would you like to do?")
                    .AddChoices(
                        Enums.CategoryMenuOptions.AddCategory,
                        Enums.CategoryMenuOptions.ViewAllCategories,
                        Enums.CategoryMenuOptions.EditCategory,
                        Enums.CategoryMenuOptions.DeleteCategory,
                        Enums.CategoryMenuOptions.BackToMainMenu
                    )
            );

            switch (userChoice)
            {
                case Enums.CategoryMenuOptions.AddCategory:
                    AnsiConsole.Clear();
                    CategoryService.InsertCategory();
                    break;
                case Enums.CategoryMenuOptions.ViewAllCategories:
                    AnsiConsole.Clear();
                    CategoryService.GetAllCategories();
                    break;
                case Enums.CategoryMenuOptions.EditCategory:
                    AnsiConsole.Clear();
                    CategoryService.UpdateCategory();
                    break;
                case Enums.CategoryMenuOptions.DeleteCategory:
                    AnsiConsole.Clear();
                    CategoryService.DeleteCategory();
                    break;
                case Enums.CategoryMenuOptions.BackToMainMenu:
                    isRunning = false;
                    break;
                default:
                    AnsiConsole.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }

    internal static void ContactMenu()
    {
        var isRunning = true;
        while (isRunning)
        {
            var userChoice = AnsiConsole.Prompt(
                new SelectionPrompt<Enums.ContactMenuOptions>()
                    .Title("What would you like to do?")
                    .AddChoices(
                        Enums.ContactMenuOptions.AddContact,
                        Enums.ContactMenuOptions.ViewContact,
                        Enums.ContactMenuOptions.ViewAllContacts,
                        Enums.ContactMenuOptions.EditContact,
                        Enums.ContactMenuOptions.DeleteContact,
                        Enums.ContactMenuOptions.BackToMainMenu
                    )
            );

            switch (userChoice)
            {
                case Enums.ContactMenuOptions.AddContact:
                    AnsiConsole.Clear();
                    ContactService.InsertContact();
                    break;
                case Enums.ContactMenuOptions.ViewContact:
                    AnsiConsole.Clear();
                    ContactService.GetContactById();
                    break;
                case Enums.ContactMenuOptions.ViewAllContacts:
                    AnsiConsole.Clear();
                    ContactService.GetAllContacts();
                    break;
                case Enums.ContactMenuOptions.EditContact:
                    AnsiConsole.Clear();
                    ContactService.UpdateContact();
                    break;
                case Enums.ContactMenuOptions.DeleteContact:
                    AnsiConsole.Clear();
                    ContactService.DeleteContact();
                    break;
                case Enums.ContactMenuOptions.BackToMainMenu:
                    isRunning = false;
                    break;
                default:
                    AnsiConsole.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }
}
