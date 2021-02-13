﻿// <auto-generated />
using CodeTestProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeTestProject.Migrations
{
    [DbContext(typeof(CodeTestContext))]
    [Migration("20210213023546_OfferUpdate")]
    partial class OfferUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeTestProject.Models.Offer", b =>
                {
                    b.Property<string>("OfferName")
                        .ValueGeneratedOnAdd();

                    b.HasKey("OfferName");

                    b.ToTable("Offer");
                });

            modelBuilder.Entity("CodeTestProject.Models.OfferProduct", b =>
                {
                    b.Property<int>("OfferProductID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OfferName");

                    b.Property<int>("ProductID");

                    b.HasKey("OfferProductID");

                    b.HasIndex("OfferName");

                    b.HasIndex("ProductID");

                    b.ToTable("OfferProduct");
                });

            modelBuilder.Entity("CodeTestProject.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ProductID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("CodeTestProject.Models.OfferProduct", b =>
                {
                    b.HasOne("CodeTestProject.Models.Offer", "Offer")
                        .WithMany("OfferProducts")
                        .HasForeignKey("OfferName");

                    b.HasOne("CodeTestProject.Models.Product", "Product")
                        .WithMany("OfferProducts")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}