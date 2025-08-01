﻿// <auto-generated />
using Api_Task_Techtroll.co.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api_Task_Techtroll.co.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250801110411_v2")]
    partial class v2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Api_Task_Techtroll.co.Domain.Entities.Component", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("Api_Task_Techtroll.co.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Api_Task_Techtroll.co.Domain.Entities.Subcomponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ComponentId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<float>("CuttingLength")
                        .HasColumnType("real");

                    b.Property<float>("CuttingThickness")
                        .HasColumnType("real");

                    b.Property<float>("CuttingWidth")
                        .HasColumnType("real");

                    b.Property<float>("DetailLength")
                        .HasColumnType("real");

                    b.Property<float>("DetailThickness")
                        .HasColumnType("real");

                    b.Property<float>("DetailWidth")
                        .HasColumnType("real");

                    b.Property<float>("FinalLength")
                        .HasColumnType("real");

                    b.Property<float>("FinalThickness")
                        .HasColumnType("real");

                    b.Property<float>("FinalWidth")
                        .HasColumnType("real");

                    b.Property<string>("InnerVeneer")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OuterVeneer")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ComponentId");

                    b.ToTable("Subcomponents");
                });

            modelBuilder.Entity("Api_Task_Techtroll.co.Domain.Entities.Component", b =>
                {
                    b.HasOne("Api_Task_Techtroll.co.Domain.Entities.Product", "Product")
                        .WithMany("Components")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Api_Task_Techtroll.co.Domain.Entities.Subcomponent", b =>
                {
                    b.HasOne("Api_Task_Techtroll.co.Domain.Entities.Component", "Component")
                        .WithMany("Subcomponents")
                        .HasForeignKey("ComponentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Component");
                });

            modelBuilder.Entity("Api_Task_Techtroll.co.Domain.Entities.Component", b =>
                {
                    b.Navigation("Subcomponents");
                });

            modelBuilder.Entity("Api_Task_Techtroll.co.Domain.Entities.Product", b =>
                {
                    b.Navigation("Components");
                });
#pragma warning restore 612, 618
        }
    }
}
