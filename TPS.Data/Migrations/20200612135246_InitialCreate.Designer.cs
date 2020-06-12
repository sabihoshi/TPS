﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TPS.Data;

namespace TPS.Data.Migrations
{
    [DbContext(typeof(TPSContext))]
    [Migration("20200612135246_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("TPS.Data.Products.Aisle", b =>
                {
                    b.Property<int>("AisleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AisleId");

                    b.ToTable("Aisles");
                });

            modelBuilder.Entity("TPS.Data.Products.Meat", b =>
                {
                    b.Property<int>("MeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("ExpiryDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("ManufacturingDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("MeatType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PerishableId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MeatId");

                    b.HasIndex("ProductId");

                    b.ToTable("Meats");
                });

            modelBuilder.Entity("TPS.Data.Products.Produce", b =>
                {
                    b.Property<int>("ProduceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("ExpiryDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Group")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("ManufacturingDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("PerishableId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProduceId");

                    b.HasIndex("ProductId");

                    b.ToTable("Produces");
                });

            modelBuilder.Entity("TPS.Data.Products.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddedIn")
                        .HasColumnType("TEXT");

                    b.Property<int?>("AisleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.HasIndex("AisleId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("TPS.Data.Sales.Credit", b =>
                {
                    b.Property<int>("CreditId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Balance")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Expiry")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("Number")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Provider")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("SecurityCode")
                        .HasColumnType("INTEGER");

                    b.HasKey("CreditId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Credits");
                });

            modelBuilder.Entity("TPS.Data.Sales.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PersonId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CustomerId");

                    b.HasIndex("PersonId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("TPS.Data.Sales.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Tax")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Total")
                        .HasColumnType("TEXT");

                    b.HasKey("TransactionId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("TPS.Data.Users.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Domain")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PersonId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AddressId");

                    b.HasIndex("PersonId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("TPS.Data.Users.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsEmployed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("JoinedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LeftAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("PersonId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmployeeId");

                    b.HasIndex("PersonId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("TPS.Data.Users.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Building")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PersonId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PostCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .HasColumnType("TEXT");

                    b.HasKey("LocationId");

                    b.HasIndex("PersonId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("TPS.Data.Users.Name", b =>
                {
                    b.Property<int>("NameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("First")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Initial")
                        .HasColumnType("TEXT");

                    b.Property<string>("Last")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("NameId");

                    b.ToTable("Name");
                });

            modelBuilder.Entity("TPS.Data.Users.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NameId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PersonId");

                    b.HasIndex("NameId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("TPS.Data.Products.Meat", b =>
                {
                    b.HasOne("TPS.Data.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TPS.Data.Products.Produce", b =>
                {
                    b.HasOne("TPS.Data.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TPS.Data.Products.Product", b =>
                {
                    b.HasOne("TPS.Data.Products.Aisle", null)
                        .WithMany("Products")
                        .HasForeignKey("AisleId");
                });

            modelBuilder.Entity("TPS.Data.Sales.Credit", b =>
                {
                    b.HasOne("TPS.Data.Sales.Customer", null)
                        .WithMany("Credits")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("TPS.Data.Sales.Customer", b =>
                {
                    b.HasOne("TPS.Data.Users.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TPS.Data.Sales.Transaction", b =>
                {
                    b.HasOne("TPS.Data.Sales.Customer", "Customer")
                        .WithMany("Transactions")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TPS.Data.Users.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TPS.Data.Users.Address", b =>
                {
                    b.HasOne("TPS.Data.Users.Person", null)
                        .WithMany("EmailAddresses")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("TPS.Data.Users.Employee", b =>
                {
                    b.HasOne("TPS.Data.Users.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TPS.Data.Users.Location", b =>
                {
                    b.HasOne("TPS.Data.Users.Person", null)
                        .WithMany("Locations")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("TPS.Data.Users.Person", b =>
                {
                    b.HasOne("TPS.Data.Users.Name", "Name")
                        .WithMany()
                        .HasForeignKey("NameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
