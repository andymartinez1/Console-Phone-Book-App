namespace Phone_Book.Models;

public class Enums
{
    public enum MainMenuOptions
    {
        ManageCategories,
        ManageContacts,
        Quit,
    }

    public enum CategoryMenuOptions
    {
        AddCategory,
        ViewAllCategories,
        EditCategory,
        DeleteCategory,
        BackToMainMenu,
    }

    public enum ContactMenuOptions
    {
        AddContact,
        ViewContact,
        ViewAllContacts,
        EditContact,
        DeleteContact,
        BackToMainMenu,
    }
}
