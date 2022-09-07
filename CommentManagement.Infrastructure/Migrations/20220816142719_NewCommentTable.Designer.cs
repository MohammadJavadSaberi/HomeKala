﻿// <auto-generated />
using System;
using CommentManagement.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CommentManagement.Infrastructure.Migrations
{
    [DbContext(typeof(CommentContext))]
    [Migration("20220816142719_NewCommentTable")]
    partial class NewCommentTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CommentManagement.Domain.CommentAgg.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(1200)
                        .HasColumnType("nvarchar(1200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("OwnerRecordId")
                        .HasColumnType("int");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("CommentManagement.Domain.CommentAgg.Comment", b =>
                {
                    b.HasOne("CommentManagement.Domain.CommentAgg.Comment", "Parent")
                        .WithMany("Childern")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("CommentManagement.Domain.CommentAgg.Comment", b =>
                {
                    b.Navigation("Childern");
                });
#pragma warning restore 612, 618
        }
    }
}