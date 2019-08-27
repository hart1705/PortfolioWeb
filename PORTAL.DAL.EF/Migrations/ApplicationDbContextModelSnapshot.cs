﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using PORTAL.DAL.EF;
using PORTAL.DAL.EF.Helper;
using System;

namespace PORTAL.DAL.EF.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Role");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PORTAL.DAL.EF.Models.Annotation", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Annotation_Id");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("DocumentBody");

                    b.Property<string>("FileName")
                        .HasMaxLength(255);

                    b.Property<int?>("FileSize");

                    b.Property<bool>("IsDocument");

                    b.Property<bool>("IsPrivate");

                    b.Property<string>("MimeType")
                        .HasMaxLength(256);

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("NoteText");

                    b.Property<string>("ObjectId");

                    b.Property<string>("ObjectName");

                    b.Property<int>("Status");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Annotation");
                });

            modelBuilder.Entity("PORTAL.DAL.EF.Models.ApplicationAction", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("AccessNeeded");

                    b.Property<string>("ActionName");

                    b.Property<string>("ApplicationAction_Id");

                    b.Property<string>("ControllerName");

                    b.Property<string>("Description");

                    b.Property<bool>("IsHttpPOST");

                    b.HasKey("Id");

                    b.ToTable("ApplicationAction");
                });

            modelBuilder.Entity("PORTAL.DAL.EF.Models.ApplicationAction_ApplicationPermission", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessType");

                    b.Property<string>("ApplicationActionId");

                    b.Property<string>("ApplicationPermissionId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationActionId");

                    b.HasIndex("ApplicationPermissionId");

                    b.ToTable("ApplicationAction_ApplicationPermission");
                });

            modelBuilder.Entity("PORTAL.DAL.EF.Models.ApplicationPermission", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationPermission_Id");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("ApplicationPermission");
                });

            modelBuilder.Entity("PORTAL.DAL.EF.Models.ApplicationRole_ApplicationPermission", b =>
                {
                    b.Property<string>("RoleId");

                    b.Property<string>("ApplicationPermissionId");

                    b.HasKey("RoleId", "ApplicationPermissionId");

                    b.HasIndex("ApplicationPermissionId");

                    b.ToTable("ApplicationRole_ApplicationPermission");
                });

            modelBuilder.Entity("PORTAL.DAL.EF.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int>("ChildPosition");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("MiddleName");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("ParentId");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<int?>("RegistrationType");

                    b.Property<string>("SecurityStamp");

                    b.Property<int>("Status");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("User");
                });

            modelBuilder.Entity("PORTAL.DAL.EF.Models.Bayanihan", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Count");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<int>("Status");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Bayanihan");
                });

            modelBuilder.Entity("PORTAL.DAL.EF.Models.GSMModem", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BaudRate");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("GSMModem_Id");

                    b.Property<int>("GSMStatus");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("PortName");

                    b.Property<int?>("ReadTimeout");

                    b.Property<int>("Status");

                    b.Property<int?>("WriteTimeout");

                    b.HasKey("Id");

                    b.ToTable("GSMModem");
                });

            modelBuilder.Entity("PORTAL.DAL.EF.Models.Income", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("BayanihanIncome");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<decimal>("DirectReferralIncome");

                    b.Property<decimal>("GeneologyIncome");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<decimal>("NetIncome");

                    b.Property<decimal>("ProductRewardBonusIncome");

                    b.Property<decimal>("SalesMatchBonusIncome");

                    b.Property<int>("Status");

                    b.Property<decimal>("Tax");

                    b.Property<decimal>("TotalBalance");

                    b.Property<decimal>("TotalCashOut");

                    b.Property<decimal>("UnilevelIncome");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Income");
                });

            modelBuilder.Entity("PORTAL.DAL.EF.Models.ReferralCode", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<DateTime?>("ExpirationDate");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("PINCode");

                    b.Property<int>("ReferralCodeStatus");

                    b.Property<string>("ReferralCode_Id");

                    b.Property<string>("SecutiryCode");

                    b.Property<int>("Status");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ReferralCode");
                });

            modelBuilder.Entity("PORTAL.DAL.EF.Models.ShortMessageService", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CompletedOn");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("ErrorMessage");

                    b.Property<string>("MessageBody")
                        .HasMaxLength(450);

                    b.Property<string>("MobileNumber")
                        .HasMaxLength(12);

                    b.Property<string>("Modem_Id");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<int>("SMSStatus");

                    b.Property<string>("ShortMessageService_Id");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("ShortMessageService");
                });

            modelBuilder.Entity("PORTAL.DAL.EF.Models.ViewModels.ApplicationPermissionView", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationPermission_Id");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<int>("Status");

                    b.Property<string>("StatusName");

                    b.HasKey("Id");

                    b.ToTable("ApplicationPermissionView");
                });

            modelBuilder.Entity("PORTAL.DAL.EF.Models.ViewModels.RoleView", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<bool>("IsSysAdmin");

                    b.Property<string>("IsSysAdminName");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.Property<int>("Status");

                    b.Property<string>("StatusName");

                    b.HasKey("Id");

                    b.ToTable("RoleView");
                });

            modelBuilder.Entity("PORTAL.DAL.EF.Models.ApplicationRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<bool>("IsSysAdmin");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<int>("Status");

                    b.ToTable("ApplicationRole");

                    b.HasDiscriminator().HasValue("ApplicationRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PORTAL.DAL.EF.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PORTAL.DAL.EF.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PORTAL.DAL.EF.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PORTAL.DAL.EF.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PORTAL.DAL.EF.Models.ApplicationAction_ApplicationPermission", b =>
                {
                    b.HasOne("PORTAL.DAL.EF.Models.ApplicationAction", "ApplicationAction")
                        .WithMany("ApplicationAction_ApplicationPermissions")
                        .HasForeignKey("ApplicationActionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PORTAL.DAL.EF.Models.ApplicationPermission", "ApplicationPermission")
                        .WithMany("ApplicationAction_ApplicationPermissions")
                        .HasForeignKey("ApplicationPermissionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PORTAL.DAL.EF.Models.ApplicationRole_ApplicationPermission", b =>
                {
                    b.HasOne("PORTAL.DAL.EF.Models.ApplicationPermission", "ApplicationPermission")
                        .WithMany("ApplicationRole_ApplicationPermissions")
                        .HasForeignKey("ApplicationPermissionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PORTAL.DAL.EF.Models.ApplicationRole", "ApplicationRole")
                        .WithMany("ApplicationRole_ApplicationPermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PORTAL.DAL.EF.Models.Bayanihan", b =>
                {
                    b.HasOne("PORTAL.DAL.EF.Models.ApplicationUser", "User")
                        .WithOne("Bayanihan")
                        .HasForeignKey("PORTAL.DAL.EF.Models.Bayanihan", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PORTAL.DAL.EF.Models.Income", b =>
                {
                    b.HasOne("PORTAL.DAL.EF.Models.ApplicationUser", "User")
                        .WithOne("Income")
                        .HasForeignKey("PORTAL.DAL.EF.Models.Income", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PORTAL.DAL.EF.Models.ReferralCode", b =>
                {
                    b.HasOne("PORTAL.DAL.EF.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
