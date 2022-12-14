﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NotesBlazorApp.Server.Data;

#nullable disable

namespace NotesBlazorApp.Server.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes", (string)null);
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.Key", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Algorithm")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DataProtected")
                        .HasColumnType("bit");

                    b.Property<bool>("IsX509Certificate")
                        .HasColumnType("bit");

                    b.Property<string>("Use")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Use");

                    b.ToTable("Keys");
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("ConsumedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Key");

                    b.HasIndex("ConsumedTime");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.HasIndex("SubjectId", "SessionId", "Type");

                    b.ToTable("PersistedGrants", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("NotesBlazorApp.Shared.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "e6ffc017-69c2-4f55-9552-9563a2cde1da",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2b539445-1d12-4d62-8f73-c63feaea15e7",
                            Email = "user1234@mail.ru",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "USER1234@MAIL.RU",
                            NormalizedUserName = "USER1234@MAIL.RU",
                            PasswordHash = "AQAAAAEAACcQAAAAEJq5wyP9ng11WdDPgSl3qdH+5qLvQi88nuYM/hS0b7+HoHky+POzcZnFLK+TAYK42Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "73NY4ALQX5ZVOAEBOYANZNXERLYLLSJD",
                            TwoFactorEnabled = false,
                            UserName = "user1234@mail.ru"
                        });
                });

            modelBuilder.Entity("NotesBlazorApp.Shared.ColorCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("ColorCards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "White",
                            Name = "FFFFFF"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Red",
                            Name = "FC6471"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Yellow",
                            Name = "FFD275"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Green Celadon",
                            Name = "A1E5AB"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Blue Purple",
                            Name = "B2ABF2"
                        });
                });

            modelBuilder.Entity("NotesBlazorApp.Shared.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("ChangedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ColorCardId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ColorCardId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Notes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ChangedDate = new DateTime(2022, 12, 15, 0, 16, 20, 542, DateTimeKind.Local).AddTicks(7055),
                            ColorCardId = 2,
                            CreatedDate = new DateTime(2022, 12, 15, 0, 16, 20, 542, DateTimeKind.Local).AddTicks(7068),
                            Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lectus vestibulum mattis ullamcorper velit sed ullamcorper morbi tincidunt. Faucibus scelerisque eleifend donec pretium. Turpis egestas maecenas pharetra convallis posuere morbi leo. ",
                            Title = "Note #1",
                            UserId = "e6ffc017-69c2-4f55-9552-9563a2cde1da"
                        },
                        new
                        {
                            Id = 2,
                            ChangedDate = new DateTime(2022, 12, 15, 0, 16, 20, 542, DateTimeKind.Local).AddTicks(7071),
                            ColorCardId = 1,
                            CreatedDate = new DateTime(2022, 12, 15, 0, 16, 20, 542, DateTimeKind.Local).AddTicks(7072),
                            Details = "Nunc mi ipsum faucibus vitae aliquet nec ullamcorper sit amet. Est ante in nibh mauris cursus mattis molestie a iaculis. Netus et malesuada fames ac turpis egestas maecenas pharetra. \r\n\r\nUt venenatis tellus in metus vulputate eu scelerisque felis. Purus ut faucibus pulvinar elementum integer enim neque volutpat. Rutrum tellus pellentesque eu tincidunt tortor aliquam.",
                            Title = "Note #2",
                            UserId = "e6ffc017-69c2-4f55-9552-9563a2cde1da"
                        },
                        new
                        {
                            Id = 3,
                            ChangedDate = new DateTime(2022, 12, 15, 0, 16, 20, 542, DateTimeKind.Local).AddTicks(7074),
                            ColorCardId = 4,
                            CreatedDate = new DateTime(2022, 12, 15, 0, 16, 20, 542, DateTimeKind.Local).AddTicks(7075),
                            Details = "Rutrum tellus pellentesque eu tincidunt tortor aliquam.",
                            Title = "Note #3",
                            UserId = "e6ffc017-69c2-4f55-9552-9563a2cde1da"
                        },
                        new
                        {
                            Id = 4,
                            ChangedDate = new DateTime(2022, 12, 15, 0, 16, 20, 542, DateTimeKind.Local).AddTicks(7076),
                            ColorCardId = 5,
                            CreatedDate = new DateTime(2022, 12, 15, 0, 16, 20, 542, DateTimeKind.Local).AddTicks(7077),
                            Details = "Donec ultrices tincidunt arcu non sodales neque sodales. Ultrices eros in cursus turpis massa. Nulla facilisi nullam vehicula ipsum. \r\n\r\nVitae semper quis lectus nulla at volutpat diam ut venenatis. Tellus in metus vulputate eu scelerisque felis imperdiet proin fermentum. Ullamcorper sit amet risus nullam eget felis. \r\n\r\nProin libero nunc consequat interdum varius sit amet. Sed arcu non odio euismod lacinia at quis. Faucibus a pellentesque sit amet. Urna neque viverra justo nec ultrices dui sapien eget mi. ",
                            Title = "Note #4",
                            UserId = "e6ffc017-69c2-4f55-9552-9563a2cde1da"
                        },
                        new
                        {
                            Id = 5,
                            ChangedDate = new DateTime(2022, 12, 15, 0, 16, 20, 542, DateTimeKind.Local).AddTicks(7079),
                            ColorCardId = 3,
                            CreatedDate = new DateTime(2022, 12, 15, 0, 16, 20, 542, DateTimeKind.Local).AddTicks(7080),
                            Details = "Aut iste quod sed repellendus dolor eos quaerat dolores At voluptas voluptatem ea iste cupiditate. Non ipsam dignissimos et eius quia et eligendi quis.",
                            Title = "Note #5",
                            UserId = "e6ffc017-69c2-4f55-9552-9563a2cde1da"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("NotesBlazorApp.Shared.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("NotesBlazorApp.Shared.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NotesBlazorApp.Shared.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("NotesBlazorApp.Shared.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NotesBlazorApp.Shared.Note", b =>
                {
                    b.HasOne("NotesBlazorApp.Shared.ColorCard", "ColorCard")
                        .WithMany("Notes")
                        .HasForeignKey("ColorCardId");

                    b.HasOne("NotesBlazorApp.Shared.ApplicationUser", "User")
                        .WithMany("Notes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ColorCard");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NotesBlazorApp.Shared.ApplicationUser", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("NotesBlazorApp.Shared.ColorCard", b =>
                {
                    b.Navigation("Notes");
                });
#pragma warning restore 612, 618
        }
    }
}
