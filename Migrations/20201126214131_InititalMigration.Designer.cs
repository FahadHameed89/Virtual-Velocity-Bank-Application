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
    [Migration("20201126214131_InititalMigration")]
    partial class InititalMigration
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
                        .HasColumnType("varchar(50)")
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
