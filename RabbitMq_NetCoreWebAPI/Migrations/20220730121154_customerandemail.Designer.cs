// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RabbitMq_NetCoreWebAPI.Data;

#nullable disable

namespace RabbitMq_NetCoreWebAPI.Migrations
{
    [DbContext(typeof(DbContextClass))]
    [Migration("20220730121154_customerandemail")]
    partial class customerandemail
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RabbitMq_NetCoreWebAPI.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerTypes")
                        .HasColumnType("int");

                    b.Property<bool>("IsAccepSms")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAcceptEmail")
                        .HasColumnType("bit");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("RabbitMq_NetCoreWebAPI.Models.Email", b =>
                {
                    b.Property<int>("EmailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmailId"), 1L, 1);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("EmailContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailSubject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmailType")
                        .HasColumnType("int");

                    b.Property<int>("ProductInfoProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SendDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EmailId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductInfoProductId");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("RabbitMq_NetCoreWebAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("int");

                    b.Property<int>("ProductStock")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("RabbitMq_NetCoreWebAPI.Models.Email", b =>
                {
                    b.HasOne("RabbitMq_NetCoreWebAPI.Models.Customer", null)
                        .WithMany("RecievedEmails")
                        .HasForeignKey("CustomerId");

                    b.HasOne("RabbitMq_NetCoreWebAPI.Models.Product", "ProductInfo")
                        .WithMany()
                        .HasForeignKey("ProductInfoProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductInfo");
                });

            modelBuilder.Entity("RabbitMq_NetCoreWebAPI.Models.Customer", b =>
                {
                    b.Navigation("RecievedEmails");
                });
#pragma warning restore 612, 618
        }
    }
}
