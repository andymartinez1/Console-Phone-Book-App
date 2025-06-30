namespace Phone_Book.Models;

public class Enums
{
    public enum CategoryMenuOptions
    {
        AddCategory,
        ViewAllCategories,
        EditCategory,
        DeleteCategory,
        BackToMainMenu
    }

    public enum ContactMenuOptions
    {
        AddContact,
        ViewContact,
        ViewAllContacts,
        EditContact,
        DeleteContact,
        BackToMainMenu
    }

    public enum MainMenuOptions
    {
        ManageCategories,
        ManageContacts,
        Quit
    }
}