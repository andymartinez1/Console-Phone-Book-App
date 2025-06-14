using Microsoft.EntityFrameworkCore;
using Phone_Book.Models;

namespace Phone_Book.Data;

internal class ContactContext : DbContext
{
    public DbSet<Contact> Contacts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=phonebook;Trusted_Connection=True");
    }
}