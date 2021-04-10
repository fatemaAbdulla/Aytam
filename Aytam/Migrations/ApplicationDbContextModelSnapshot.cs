﻿// <auto-generated />
using System;
using Aytam.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aytam.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Aytam.Data.Country", b =>
                {
                    b.Property<string>("CountryCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("CountryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CountryCode");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Aytam.Data.Document", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DocumentURL")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PaymentID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PersonID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TypeID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("PaymentID");

                    b.HasIndex("PersonID");

                    b.HasIndex("TypeID");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("Aytam.Data.DocumentType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("DocumentTypes");
                });

            modelBuilder.Entity("Aytam.Data.Income", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ParentID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TypeID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("ParentID");

                    b.HasIndex("TypeID");

                    b.ToTable("Incomes");
                });

            modelBuilder.Entity("Aytam.Data.IncomeType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("IncomeTypes");
                });

            modelBuilder.Entity("Aytam.Data.Invoice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SponsorshipID")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("SponsorshipID");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Aytam.Data.JobTitle", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("JobTitles");
                });

            modelBuilder.Entity("Aytam.Data.Payment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChequeNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int?>("InvoiceID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsExpense")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PaidByID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PaymentTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PersonID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RecievedByID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RecievedOnBehalfOfID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("InvoiceID");

                    b.HasIndex("PaidByID");

                    b.HasIndex("PaymentTypeID");

                    b.HasIndex("PersonID");

                    b.HasIndex("RecievedByID");

                    b.HasIndex("RecievedOnBehalfOfID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Aytam.Data.PaymentType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isExpense")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("PaymentTypes");
                });

            modelBuilder.Entity("Aytam.Data.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CPR")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MiddleNames")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("image")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("CPR")
                        .IsUnique();

                    b.ToTable("People");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("Aytam.Data.Sponsorship", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<int?>("OrphanID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PaymentFrequency")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SponsorID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("OrphanID");

                    b.HasIndex("SponsorID");

                    b.ToTable("Sponsorships");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Aytam.Data.Orphan", b =>
                {
                    b.HasBaseType("Aytam.Data.Person");

                    b.Property<int?>("FatherID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GuardianID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MotherID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ParentID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isSayed")
                        .HasColumnType("INTEGER");

                    b.HasIndex("FatherID");

                    b.HasIndex("GuardianID");

                    b.HasIndex("MotherID");

                    b.HasIndex("ParentID");

                    b.HasDiscriminator().HasValue("Orphan");
                });

            modelBuilder.Entity("Aytam.Data.Parent", b =>
                {
                    b.HasBaseType("Aytam.Data.Person");

                    b.Property<DateTime?>("DateOfDeath")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FinancialStatus")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("JobTitleID")
                        .HasColumnType("TEXT");

                    b.HasIndex("JobTitleID");

                    b.HasDiscriminator().HasValue("Parent");
                });

            modelBuilder.Entity("Aytam.Data.Sponsor", b =>
                {
                    b.HasBaseType("Aytam.Data.Person");

                    b.HasDiscriminator().HasValue("Sponsor");
                });

            modelBuilder.Entity("Aytam.Data.Document", b =>
                {
                    b.HasOne("Aytam.Data.Payment", null)
                        .WithMany("Documents")
                        .HasForeignKey("PaymentID");

                    b.HasOne("Aytam.Data.Person", null)
                        .WithMany("Documents")
                        .HasForeignKey("PersonID");

                    b.HasOne("Aytam.Data.DocumentType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeID");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Aytam.Data.Income", b =>
                {
                    b.HasOne("Aytam.Data.Parent", null)
                        .WithMany("Incomes")
                        .HasForeignKey("ParentID");

                    b.HasOne("Aytam.Data.IncomeType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeID");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Aytam.Data.Invoice", b =>
                {
                    b.HasOne("Aytam.Data.Sponsorship", null)
                        .WithMany("Invoices")
                        .HasForeignKey("SponsorshipID");
                });

            modelBuilder.Entity("Aytam.Data.Payment", b =>
                {
                    b.HasOne("Aytam.Data.Invoice", null)
                        .WithMany("Payments")
                        .HasForeignKey("InvoiceID");

                    b.HasOne("Aytam.Data.Person", "PaidBy")
                        .WithMany()
                        .HasForeignKey("PaidByID");

                    b.HasOne("Aytam.Data.PaymentType", "PaymentType")
                        .WithMany()
                        .HasForeignKey("PaymentTypeID");

                    b.HasOne("Aytam.Data.Person", null)
                        .WithMany("Payments")
                        .HasForeignKey("PersonID");

                    b.HasOne("Aytam.Data.Person", "RecievedBy")
                        .WithMany()
                        .HasForeignKey("RecievedByID");

                    b.HasOne("Aytam.Data.Person", "RecievedOnBehalfOf")
                        .WithMany()
                        .HasForeignKey("RecievedOnBehalfOfID");

                    b.Navigation("PaidBy");

                    b.Navigation("PaymentType");

                    b.Navigation("RecievedBy");

                    b.Navigation("RecievedOnBehalfOf");
                });

            modelBuilder.Entity("Aytam.Data.Person", b =>
                {
                    b.OwnsOne("Aytam.Data.ContactInfo", "ContactInfo", b1 =>
                        {
                            b1.Property<int>("PersonID")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Email")
                                .HasColumnType("TEXT");

                            b1.Property<string>("MobileNumber")
                                .HasColumnType("TEXT");

                            b1.Property<string>("PhoneNumber")
                                .HasColumnType("TEXT");

                            b1.HasKey("PersonID");

                            b1.ToTable("People");

                            b1.WithOwner()
                                .HasForeignKey("PersonID");

                            b1.OwnsOne("Aytam.Data.Address", "Address", b2 =>
                                {
                                    b2.Property<int>("ContactInfoPersonID")
                                        .HasColumnType("INTEGER");

                                    b2.Property<string>("AddressLine1")
                                        .HasColumnType("TEXT");

                                    b2.Property<string>("AddressLine2")
                                        .HasColumnType("TEXT");

                                    b2.Property<string>("AddressLine3")
                                        .HasColumnType("TEXT");

                                    b2.Property<string>("City")
                                        .HasColumnType("TEXT");

                                    b2.Property<string>("CountryCode")
                                        .HasColumnType("TEXT");

                                    b2.HasKey("ContactInfoPersonID");

                                    b2.HasIndex("CountryCode");

                                    b2.ToTable("People");

                                    b2.WithOwner()
                                        .HasForeignKey("ContactInfoPersonID");

                                    b2.HasOne("Aytam.Data.Country", "Country")
                                        .WithMany()
                                        .HasForeignKey("CountryCode");

                                    b2.Navigation("Country");
                                });

                            b1.Navigation("Address");
                        });

                    b.Navigation("ContactInfo");
                });

            modelBuilder.Entity("Aytam.Data.Sponsorship", b =>
                {
                    b.HasOne("Aytam.Data.Orphan", "Orphan")
                        .WithMany("Sponsorships")
                        .HasForeignKey("OrphanID");

                    b.HasOne("Aytam.Data.Sponsor", "Sponsor")
                        .WithMany("Sponsorships")
                        .HasForeignKey("SponsorID");

                    b.Navigation("Orphan");

                    b.Navigation("Sponsor");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aytam.Data.Orphan", b =>
                {
                    b.HasOne("Aytam.Data.Parent", "Father")
                        .WithMany()
                        .HasForeignKey("FatherID");

                    b.HasOne("Aytam.Data.Parent", "Guardian")
                        .WithMany()
                        .HasForeignKey("GuardianID");

                    b.HasOne("Aytam.Data.Parent", "Mother")
                        .WithMany()
                        .HasForeignKey("MotherID");

                    b.HasOne("Aytam.Data.Parent", null)
                        .WithMany("Children")
                        .HasForeignKey("ParentID");

                    b.Navigation("Father");

                    b.Navigation("Guardian");

                    b.Navigation("Mother");
                });

            modelBuilder.Entity("Aytam.Data.Parent", b =>
                {
                    b.HasOne("Aytam.Data.JobTitle", "JobTitle")
                        .WithMany()
                        .HasForeignKey("JobTitleID");

                    b.Navigation("JobTitle");
                });

            modelBuilder.Entity("Aytam.Data.Invoice", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("Aytam.Data.Payment", b =>
                {
                    b.Navigation("Documents");
                });

            modelBuilder.Entity("Aytam.Data.Person", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("Aytam.Data.Sponsorship", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("Aytam.Data.Orphan", b =>
                {
                    b.Navigation("Sponsorships");
                });

            modelBuilder.Entity("Aytam.Data.Parent", b =>
                {
                    b.Navigation("Children");

                    b.Navigation("Incomes");
                });

            modelBuilder.Entity("Aytam.Data.Sponsor", b =>
                {
                    b.Navigation("Sponsorships");
                });
#pragma warning restore 612, 618
        }
    }
}
