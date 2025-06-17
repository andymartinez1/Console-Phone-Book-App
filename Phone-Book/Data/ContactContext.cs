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
        modelBuilder
            .Entity<Contact>()
            .HasOne(c => c.Category)
            .WithMany(c => c.Contacts)
            .HasForeignKey(c => c.CategoryId);

        modelBuilder
            .Entity<Category>()
            .HasData(
                new List<Category>
                {
                    new Category { CategoryId = 1, CategoryName = "Family" },
                    new Category { CategoryId = 2, CategoryName = "Friends" },
                    new Category { CategoryId = 3, CategoryName = "Work" },
                }
            );

        modelBuilder
            .Entity<Contact>()
            .HasData(
                new List<Contact>
                {
                    new Contact
                    {
                        Id = 1,
                        Name = "John Doe",
                        Email = "JDoe@gmail.com",
                        Phone = "1234567890",
                        CategoryId = 1,
                    },
                    new Contact
                    {
                        Id = 2,
                        Name = "Jane Smith",
                        Email = "jsmith@hotmail.com",
                        Phone = "0987654321",
                        CategoryId = 2,
                    },
                    new Contact
                    {
                        Id = 3,
                        Name = "Alice Johnson",
                        Email = "alicej@gmail.com",
                        Phone = "5555555555",
                        CategoryId = 3,
                    },
                    new Contact
                    {
                        Id = 4,
                        Name = "Bob Brown",
                        Email = "bbrown@yahoo.com",
                        Phone = "4444444444",
                        CategoryId = 1,
                    },
                    new Contact
                    {
                        Id = 5,
                        Name = "Charlie White",
                        Email = "charliew@aol.com",
                        Phone = "3333333333",
                        CategoryId = 2,
                    },
                    new Contact
                    {
                        Id = 6,
                        Name = "David Green",
                        Email = "davidg@gmail.com",
                        Phone = "2222222222",
                        CategoryId = 3,
                    },
                }
            );
    }
}
