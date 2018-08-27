﻿// <auto-generated />
using System;
using ContactsCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContactsCore.Migrations
{
    [DbContext(typeof(ContactsContext))]
    [Migration("20180827132933_AddPersonPhoneAndType")]
    partial class AddPersonPhoneAndType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContactsCore.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(35);

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(5,2)");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(35);

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("ContactsCore.PersonPhone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PersonId");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("PersonPhone");
                });

            modelBuilder.Entity("ContactsCore.PersonPhone", b =>
                {
                    b.HasOne("ContactsCore.Person", "Person")
                        .WithMany("Phones")
                        .HasForeignKey("PersonId");
                });
#pragma warning restore 612, 618
        }
    }
}