﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OPC5_BlogApp.Data;

#nullable disable

namespace OPC5_BlogApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240226150420_added_post_users")]
    partial class added_post_users
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("OPC5_BlogApp.Data.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CommentUserUserId")
                        .HasColumnType("int");

                    b.Property<int?>("PostId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("CommentUserUserId");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("OPC5_BlogApp.Data.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PostData")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PostDownvotes")
                        .HasColumnType("int");

                    b.Property<int>("PostUpvotes")
                        .HasColumnType("int");

                    b.Property<int>("PostUserUserId")
                        .HasColumnType("int");

                    b.HasKey("PostId");

                    b.HasIndex("PostUserUserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("OPC5_BlogApp.Data.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TagId");

                    b.HasIndex("PostId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("OPC5_BlogApp.Data.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Hashed")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OPC5_BlogApp.Data.Models.Comment", b =>
                {
                    b.HasOne("OPC5_BlogApp.Data.Models.User", "CommentUser")
                        .WithMany()
                        .HasForeignKey("CommentUserUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OPC5_BlogApp.Data.Models.Post", null)
                        .WithMany("PostComments")
                        .HasForeignKey("PostId");

                    b.Navigation("CommentUser");
                });

            modelBuilder.Entity("OPC5_BlogApp.Data.Models.Post", b =>
                {
                    b.HasOne("OPC5_BlogApp.Data.Models.User", "PostUser")
                        .WithMany()
                        .HasForeignKey("PostUserUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PostUser");
                });

            modelBuilder.Entity("OPC5_BlogApp.Data.Models.Tag", b =>
                {
                    b.HasOne("OPC5_BlogApp.Data.Models.Post", null)
                        .WithMany("PostTags")
                        .HasForeignKey("PostId");
                });

            modelBuilder.Entity("OPC5_BlogApp.Data.Models.Post", b =>
                {
                    b.Navigation("PostComments");

                    b.Navigation("PostTags");
                });
#pragma warning restore 612, 618
        }
    }
}