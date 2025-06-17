using Phone_Book.Data;
using Phone_Book.Models;

namespace Phone_Book.Controllers;

public class CategoryController
{
    internal static void AddCategory(Category category)
    {
        using var db = new ContactContext();
        db.Add(category);
        db.SaveChanges();
    }
}
