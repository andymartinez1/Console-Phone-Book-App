using Phone_Book.Controllers;
using Phone_Book.Models;
using Phone_Book.Views;
using Spectre.Console;

namespace Phone_Book.Services;

public class ContactService
{
    internal static void InsertContact()
    {
        var contact = new Contact();

        contact.Name = AnsiConsole.Ask<string>("What is the contact's name?");
        contact.Email = AnsiConsole.Ask<string>(
            "What is the contact's email? (format: example@example.com)"
        );
        if (!Validator.IsValidEmail(contact.Email))
        {
            contact.Email = AnsiConsole.Ask<string>(
                "Incorrect format. Try again (format: example@example.com)"
            );
        }
        contact.Phone = AnsiConsole.Ask<string>(
            "What is the contact's phone number? (format: 123-456-7890)"
        );

        ContactController.AddContact(contact);
    }

    internal static void UpdateContact()
    {
        var contact = GetContactByName();

        contact.Name = AnsiConsole.Confirm("Update name?")
            ? contact.Name = AnsiConsole.Ask<string>("Enter new name:")
            : contact.Name;

        contact.Email = AnsiConsole.Confirm("Update email?")
            ? contact.Email = AnsiConsole.Ask<string>(
                "Enter new email: (format: example@example.com)"
            )
            : contact.Email;

        contact.Phone = AnsiConsole.Confirm("Update phone number?")
            ? contact.Phone = AnsiConsole.Ask<string>(
                "Enter new phone number: (format: 123-456-7890)"
            )
            : contact.Phone;

        ContactController.EditContact(contact);
    }

    internal static void DeleteContact()
    {
        var contact = GetContactByName();

        ContactController.DeleteContact(contact);
    }

    internal static void GetContactById()
    {
        var contact = GetContactByName();

        UserInterface.ShowContactTable(contact);
    }

    internal static void GetAllContacts()
    {
        var contacts = ContactController.GetAllContacts();

        UserInterface.ShowAllContactsTable(contacts);
    }

    internal static Contact GetContactByName()
    {
        var contacts = ContactController.GetAllContacts();

        var contactsArray = contacts.Select(c => c.Name).ToArray();
        var option = AnsiConsole.Prompt(
            new SelectionPrompt<string>().Title("Choose an option:").AddChoices(contactsArray)
        );

        var contactId = contacts.Single(c => c.Name == option).Id;
        var contact = ContactController.GetContactById(contactId);

        return contact;
    }
}
