using Phone_Book.Models;
using Spectre.Console;

namespace Phone_Book.Views;

internal class UserInterface
{
    internal static void ShowAllContactsTable(List<Contact> contacts)
    {
        var table = new Table();
        table.AddColumn("Id");
        table.AddColumn("Name");
        table.AddColumn("Email");
        table.AddColumn("Phone Number");

        foreach (var contact in contacts)
        {
            table.AddRow(contact.Id.ToString(), contact.Name, contact.Email, contact.Phone);
        }

        AnsiConsole.Write(table);
    }

    public static void ShowContactTable(Contact contact)
    {
        var panel = new Panel(
            $@"Id: {contact.Id} 
Name: {contact.Name}
Email: {contact.Email}
Phone Number: {contact.Phone}"
        );
        panel.Header = new PanelHeader("Contact Information: ");
        panel.Padding = new Padding(2);

        AnsiConsole.Write(panel);
    }
}
