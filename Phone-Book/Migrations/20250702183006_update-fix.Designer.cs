﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Phone_Book.Data;

#nullable disable

namespace Phone_Book.Migrations
{
    [DbContext(typeof(ContactContext))]
    [Migration("20250702183006_update-fix")]
    partial class updatefix
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Phone_Book.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Friends"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Work"
                        });
                });

            modelBuilder.Entity("Phone_Book.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Email = "jhusher0@ted.com",
                            Name = "Julienne Husher",
                            Phone = "128-187-6389"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Email = "fkemball1@webmd.com",
                            Name = "Farlay Kemball",
                            Phone = "178-994-6729"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Email = "ggarahan2@51.la",
                            Name = "Golda Garahan",
                            Phone = "468-314-0933"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Email = "lmaccague3@w3.org",
                            Name = "Lisha MacCague",
                            Phone = "999-787-9493"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Email = "nbockin4@taobao.com",
                            Name = "Nikki Bockin",
                            Phone = "847-451-1638"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Email = "jgrishanov5@blogger.com",
                            Name = "Jemimah Grishanov",
                            Phone = "606-400-0266"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Email = "tlettuce6@tuttocitta.it",
                            Name = "Tersina Lettuce",
                            Phone = "164-204-3869"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Email = "grampling7@yellowpages.com",
                            Name = "Gradey Rampling",
                            Phone = "649-743-0045"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Email = "smollnar8@hubpages.com",
                            Name = "Simonette Mollnar",
                            Phone = "120-226-6327"
                        });
                });

            modelBuilder.Entity("Phone_Book.Models.Contact", b =>
                {
                    b.HasOne("Phone_Book.Models.Category", "Category")
                        .WithMany("Contacts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Phone_Book.Models.Category", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
