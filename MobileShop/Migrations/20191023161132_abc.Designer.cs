﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MobileShop.Data;
using System;

namespace MobileShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191023161132_abc")]
    partial class abc
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MobileShop.Data.Models.Account", b =>
                {
                    b.Property<int>("Account_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Account_Email")
                        .IsRequired();

                    b.Property<string>("Account_FullName")
                        .IsRequired();

                    b.Property<string>("Account_IsBlocked");

                    b.Property<string>("Account_Password")
                        .IsRequired();

                    b.Property<string>("Account_Permission");

                    b.Property<string>("Account_Phone")
                        .IsRequired();

                    b.Property<string>("Account_Sex");

                    b.HasKey("Account_Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("MobileShop.Data.Models.Category", b =>
                {
                    b.Property<int>("Category_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category_Description");

                    b.Property<string>("Category_Name");

                    b.HasKey("Category_Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MobileShop.Data.Models.Product", b =>
                {
                    b.Property<int>("Product_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Category_Id");

                    b.Property<string>("Product_ImageThumbnail");

                    b.Property<string>("Product_ImageUrl");

                    b.Property<bool>("Product_InStock");

                    b.Property<bool>("Product_IsPreferred");

                    b.Property<string>("Product_LongDescription");

                    b.Property<string>("Product_Name");

                    b.Property<decimal>("Product_Price");

                    b.Property<string>("Product_ShortDescription");

                    b.HasKey("Product_Id");

                    b.HasIndex("Category_Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MobileShop.Data.Models.Product", b =>
                {
                    b.HasOne("MobileShop.Data.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
