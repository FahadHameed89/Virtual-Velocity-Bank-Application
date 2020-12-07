﻿// <auto-generated />
using System;
using Capstone_VV.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Capstone_VV.Migrations
{
    [DbContext(typeof(BankContext))]
    [Migration("20201207224051_updatedPasswordLength")]
    partial class updatedPasswordLength
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Capstone_VV.Models.Account", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<double>("AccountBalance")
                        .HasColumnType("double(15,2)");

                    b.Property<DateTime>("AccountDate")
                        .HasColumnType("date");

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<double>("Cashback")
                        .HasColumnType("double(15,2)");

                    b.Property<int>("ClientID")
                        .HasColumnType("int(10)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bool");

                    b.HasKey("AccountID");

                    b.HasIndex("ClientID")
                        .HasName("FK_Account_Client");

                    b.ToTable("Account");

                    b.HasData(
                        new
                        {
                            AccountID = 1,
                            AccountBalance = 2189.4299999999998,
                            AccountDate = new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AccountType = "Chequing",
                            Cashback = 10.02,
                            ClientID = 1,
                            IsActive = true
                        },
                        new
                        {
                            AccountID = 2,
                            AccountBalance = 20550.43,
                            AccountDate = new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AccountType = "Savings",
                            Cashback = 23.579999999999998,
                            ClientID = 1,
                            IsActive = true
                        },
                        new
                        {
                            AccountID = 3,
                            AccountBalance = 144.0,
                            AccountDate = new DateTime(2018, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AccountType = "Chequing",
                            Cashback = 5.7999999999999998,
                            ClientID = 2,
                            IsActive = true
                        },
                        new
                        {
                            AccountID = 4,
                            AccountBalance = 77850.0,
                            AccountDate = new DateTime(2018, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AccountType = "Chequing",
                            Cashback = 100.06999999999999,
                            ClientID = 3,
                            IsActive = true
                        },
                        new
                        {
                            AccountID = 5,
                            AccountBalance = 174.09999999999999,
                            AccountDate = new DateTime(2018, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AccountType = "Chequing",
                            Cashback = 45.0,
                            ClientID = 4,
                            IsActive = true
                        });
                });

            modelBuilder.Entity("Capstone_VV.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("char(15)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.HasKey("ClientID");

                    b.ToTable("Client");

                    b.HasData(
                        new
                        {
                            ClientID = 1,
                            Address = "154 South Gate Blwd",
                            City = "Edmonton",
                            DateOfBirth = new DateTime(1989, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "johndoe123@gmail.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "John123!Unknown",
                            PhoneNumber = "7804188874",
                            PostalCode = "T8N3A4",
                            Province = "AB"
                        },
                        new
                        {
                            ClientID = 2,
                            Address = "1010 White Ave",
                            City = "London",
                            DateOfBirth = new DateTime(1880, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "trevorbelmont123@gmail.com",
                            FirstName = "Trevor",
                            LastName = "Belmont",
                            Password = "Draculasux@lif3",
                            PhoneNumber = "7804442121",
                            PostalCode = "Z4A2B1",
                            Province = "ON"
                        },
                        new
                        {
                            ClientID = 3,
                            Address = "2 Century Drive",
                            City = "Edmonton",
                            DateOfBirth = new DateTime(1999, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "richardrich@gmail.com",
                            FirstName = "Richard",
                            LastName = "Rich",
                            Password = "Therich123!@#",
                            PhoneNumber = "7771115454",
                            PostalCode = "T8N3E1",
                            Province = "AB"
                        },
                        new
                        {
                            ClientID = 4,
                            Address = "145 Gateway DR",
                            City = "Edmonton",
                            DateOfBirth = new DateTime(1979, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "brokeasajoke@gmail.com",
                            FirstName = "Bruce",
                            LastName = "Hunter",
                            Password = "password123@JOKE",
                            PhoneNumber = "7809198888",
                            PostalCode = "T8N6Y3",
                            Province = "AB"
                        });
                });

            modelBuilder.Entity("Capstone_VV.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<int>("AccountID")
                        .HasColumnType("int(10)");

                    b.Property<bool>("IsTransactionActive")
                        .HasColumnType("bool");

                    b.Property<string>("TransactionCategory")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("date");

                    b.Property<string>("TransactionSource")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<double>("TransactionValue")
                        .HasColumnType("double(15,2)");

                    b.HasKey("TransactionID");

                    b.HasIndex("AccountID")
                        .HasName("FK_Transaction_Account");

                    b.ToTable("Transaction");

                    b.HasData(
                        new
                        {
                            TransactionID = 1,
                            AccountID = 1,
                            IsTransactionActive = true,
                            TransactionCategory = "Deposit",
                            TransactionDate = new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TransactionSource = "Bank",
                            TransactionValue = 2001.8599999999999
                        },
                        new
                        {
                            TransactionID = 2,
                            AccountID = 1,
                            IsTransactionActive = true,
                            TransactionCategory = "Rent",
                            TransactionDate = new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TransactionSource = "Bill Payment",
                            TransactionValue = 1100.0
                        },
                        new
                        {
                            TransactionID = 3,
                            AccountID = 1,
                            IsTransactionActive = true,
                            TransactionCategory = "Other",
                            TransactionDate = new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TransactionSource = "Bill Payment",
                            TransactionValue = 200.0
                        },
                        new
                        {
                            TransactionID = 4,
                            AccountID = 1,
                            IsTransactionActive = true,
                            TransactionCategory = "Food",
                            TransactionDate = new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TransactionSource = "Bill Payment",
                            TransactionValue = 50.0
                        },
                        new
                        {
                            TransactionID = 5,
                            AccountID = 1,
                            IsTransactionActive = true,
                            TransactionCategory = "Health",
                            TransactionDate = new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TransactionSource = "Bill Payment",
                            TransactionValue = 30.0
                        },
                        new
                        {
                            TransactionID = 6,
                            AccountID = 1,
                            IsTransactionActive = true,
                            TransactionCategory = "Deposit",
                            TransactionDate = new DateTime(2020, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TransactionSource = "ATM",
                            TransactionValue = 430.0
                        },
                        new
                        {
                            TransactionID = 7,
                            AccountID = 1,
                            IsTransactionActive = true,
                            TransactionCategory = "Deposit",
                            TransactionDate = new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TransactionSource = "ATM",
                            TransactionValue = 110.0
                        },
                        new
                        {
                            TransactionID = 8,
                            AccountID = 1,
                            IsTransactionActive = true,
                            TransactionCategory = "Deposit",
                            TransactionDate = new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TransactionSource = "Bank",
                            TransactionValue = 320.0
                        },
                        new
                        {
                            TransactionID = 9,
                            AccountID = 1,
                            IsTransactionActive = true,
                            TransactionCategory = "Deposit",
                            TransactionDate = new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TransactionSource = "Bank",
                            TransactionValue = 750.0
                        },
                        new
                        {
                            TransactionID = 10,
                            AccountID = 2,
                            IsTransactionActive = true,
                            TransactionCategory = "Withdraw",
                            TransactionDate = new DateTime(2020, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TransactionSource = "ATM",
                            TransactionValue = 50.0
                        },
                        new
                        {
                            TransactionID = 11,
                            AccountID = 2,
                            IsTransactionActive = true,
                            TransactionCategory = "Food",
                            TransactionDate = new DateTime(2020, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TransactionSource = "Bill Payment",
                            TransactionValue = 10.0
                        },
                        new
                        {
                            TransactionID = 12,
                            AccountID = 3,
                            IsTransactionActive = true,
                            TransactionCategory = "Deposit",
                            TransactionDate = new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TransactionSource = "Bank",
                            TransactionValue = 7500.0
                        },
                        new
                        {
                            TransactionID = 13,
                            AccountID = 3,
                            IsTransactionActive = true,
                            TransactionCategory = "Deposit",
                            TransactionDate = new DateTime(2020, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TransactionSource = "Bank",
                            TransactionValue = 7500.0
                        },
                        new
                        {
                            TransactionID = 14,
                            AccountID = 3,
                            IsTransactionActive = true,
                            TransactionCategory = "Withdraw",
                            TransactionDate = new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TransactionSource = "Bank",
                            TransactionValue = 3000.0
                        },
                        new
                        {
                            TransactionID = 15,
                            AccountID = 3,
                            IsTransactionActive = true,
                            TransactionCategory = "Deposit",
                            TransactionDate = new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TransactionSource = "Bank",
                            TransactionValue = 43750.0
                        },
                        new
                        {
                            TransactionID = 16,
                            AccountID = 3,
                            IsTransactionActive = true,
                            TransactionCategory = "Deposit",
                            TransactionDate = new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TransactionSource = "Bank",
                            TransactionValue = 22100.0
                        },
                        new
                        {
                            TransactionID = 17,
                            AccountID = 4,
                            IsTransactionActive = true,
                            TransactionCategory = "Deposit",
                            TransactionDate = new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TransactionSource = "ATM",
                            TransactionValue = 1100.3199999999999
                        },
                        new
                        {
                            TransactionID = 18,
                            AccountID = 4,
                            IsTransactionActive = true,
                            TransactionCategory = "Rent",
                            TransactionDate = new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TransactionSource = "Bill Payment",
                            TransactionValue = 800.0
                        },
                        new
                        {
                            TransactionID = 19,
                            AccountID = 4,
                            IsTransactionActive = true,
                            TransactionCategory = "Utilities",
                            TransactionDate = new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TransactionSource = "Bill Payment",
                            TransactionValue = 41.990000000000002
                        },
                        new
                        {
                            TransactionID = 20,
                            AccountID = 4,
                            IsTransactionActive = true,
                            TransactionCategory = "Internet",
                            TransactionDate = new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TransactionSource = "Bill Payment",
                            TransactionValue = 84.230000000000004
                        });
                });

            modelBuilder.Entity("Capstone_VV.Models.Account", b =>
                {
                    b.HasOne("Capstone_VV.Models.Client", "Client")
                        .WithMany("Accounts")
                        .HasForeignKey("ClientID")
                        .HasConstraintName("FK_Account_Client")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Capstone_VV.Models.Transaction", b =>
                {
                    b.HasOne("Capstone_VV.Models.Account", "Account")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountID")
                        .HasConstraintName("FK_Transaction_Account")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
