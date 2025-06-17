using Microsoft.EntityFrameworkCore;
using Phone_Book.Models;

namespace Phone_Book.Data;

internal class ContactContext : DbContext
{
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=phonebook;Trusted_Connection=True"
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contact>().HasKey(c => c.Id);

        modelBuilder.Entity<Category>().HasKey(c => c.CategoryId);

        modelBuilder
            .Entity<Category>()
            .HasMany(c => c.Contacts)
            .WithOne()
            .HasForeignKey(c => c.Category.CategoryId);
    }
}
