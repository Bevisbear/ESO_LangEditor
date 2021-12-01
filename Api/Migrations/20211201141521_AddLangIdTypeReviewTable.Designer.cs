﻿// <auto-generated />
using System;
using EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(LangtextApiDbContext))]
    [Migration("20211201141521_AddLangIdTypeReviewTable")]
    partial class AddLangIdTypeReviewTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.GameVersion", b =>
                {
                    b.Property<int>("GameApiVersion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GameApiVersion"));

                    b.Property<string>("Version_EN")
                        .HasColumnType("text");

                    b.Property<string>("Version_ZH")
                        .HasColumnType("text");

                    b.HasKey("GameApiVersion");

                    b.ToTable("GameVersion");
                });

            modelBuilder.Entity("Core.Entities.LangText", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("EnLastModifyTimestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("GameApiVersion")
                        .HasColumnType("integer");

                    b.Property<int>("IdType")
                        .HasColumnType("integer");

                    b.Property<byte>("LangTextType")
                        .HasColumnType("smallint");

                    b.Property<Guid?>("LangtextInReivewId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ReviewTimestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ReviewerId")
                        .HasColumnType("uuid");

                    b.Property<int>("Revised")
                        .HasColumnType("integer");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.Property<string>("TextEn")
                        .HasColumnType("text");

                    b.Property<string>("TextId")
                        .HasColumnType("text");

                    b.Property<string>("TextZh")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ZhLastModifyTimestamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("GameApiVersion");

                    b.HasIndex("IdType");

                    b.HasIndex("LangtextInReivewId");

                    b.HasIndex("ReviewerId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("Langtexts");
                });

            modelBuilder.Entity("Core.Entities.LangTextArchive", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ArchiveTimestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("EnLastModifyTimestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("GameApiVersion")
                        .HasColumnType("integer");

                    b.Property<int>("IdType")
                        .HasColumnType("integer");

                    b.Property<byte>("LangTextType")
                        .HasColumnType("smallint");

                    b.Property<int>("ReasonFor")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ReviewTimestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ReviewerId")
                        .HasColumnType("uuid");

                    b.Property<int>("Revised")
                        .HasColumnType("integer");

                    b.Property<string>("TextEn")
                        .HasColumnType("text");

                    b.Property<string>("TextId")
                        .HasColumnType("text");

                    b.Property<string>("TextZh")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ZhLastModifyTimestamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("GameApiVersion");

                    b.HasIndex("IdType");

                    b.HasIndex("ReviewerId");

                    b.HasIndex("UserId");

                    b.ToTable("LangtextArchive");
                });

            modelBuilder.Entity("Core.Entities.LangTextReview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("EnLastModifyTimestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("GameApiVersion")
                        .HasColumnType("integer");

                    b.Property<int>("IdType")
                        .HasColumnType("integer");

                    b.Property<byte>("LangTextType")
                        .HasColumnType("smallint");

                    b.Property<int>("ReasonFor")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ReviewTimestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ReviewerId")
                        .HasColumnType("uuid");

                    b.Property<int>("Revised")
                        .HasColumnType("integer");

                    b.Property<string>("TextEn")
                        .HasColumnType("text");

                    b.Property<string>("TextId")
                        .HasColumnType("text");

                    b.Property<string>("TextZh")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ZhLastModifyTimestamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("GameApiVersion");

                    b.HasIndex("IdType");

                    b.HasIndex("ReviewerId");

                    b.HasIndex("UserId");

                    b.ToTable("LangtextReview");
                });

            modelBuilder.Entity("Core.Entities.LangTextRevised", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("LangTextRevNumber")
                        .HasColumnType("integer");

                    b.Property<Guid>("LangtextID")
                        .HasColumnType("uuid");

                    b.Property<int>("ReasonFor")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("LangtextRevised");
                });

            modelBuilder.Entity("Core.Entities.LangTextRevNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Rev")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("LangtextRevNumber");
                });

            modelBuilder.Entity("Core.Entities.LangTypeCatalog", b =>
                {
                    b.Property<int>("IdType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdType"));

                    b.Property<string>("IdTypeZH")
                        .HasColumnType("text");

                    b.HasKey("IdType");

                    b.ToTable("LangTypeCatalog");
                });

            modelBuilder.Entity("Core.Entities.LangTypeCatalogReview", b =>
                {
                    b.Property<int>("IdType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdType"));

                    b.Property<string>("IdTypeZH")
                        .HasColumnType("text");

                    b.HasKey("IdType");

                    b.ToTable("LangTypeCatalogReview");
                });

            modelBuilder.Entity("Core.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<int>("InReviewCount")
                        .HasColumnType("integer");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("text");

                    b.Property<DateTime?>("RefreshTokenExpireTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("RemovedCount")
                        .HasColumnType("integer");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<int>("TranslatedCount")
                        .HasMaxLength(20)
                        .HasColumnType("integer");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("UserNickName")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Core.Entities.UserRegistrationCode", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<DateTime>("RequestTimestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("UsedTimestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserRequest")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserUsed")
                        .HasColumnType("uuid");

                    b.HasKey("Code");

                    b.HasIndex("UserRequest");

                    b.HasIndex("UserUsed");

                    b.ToTable("UserRegistrationCode");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Core.Entities.LangText", b =>
                {
                    b.HasOne("Core.Entities.GameVersion", "GameVersion")
                        .WithMany()
                        .HasForeignKey("GameApiVersion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.LangTypeCatalog", "LangCatalog")
                        .WithMany()
                        .HasForeignKey("IdType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.LangTextReview", "LangtextInReview")
                        .WithMany()
                        .HasForeignKey("LangtextInReivewId");

                    b.HasOne("Core.Entities.User", "UserForReview")
                        .WithMany()
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Role", "RoleToEdit")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.User", "UserForModify")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GameVersion");

                    b.Navigation("LangCatalog");

                    b.Navigation("LangtextInReview");

                    b.Navigation("RoleToEdit");

                    b.Navigation("UserForModify");

                    b.Navigation("UserForReview");
                });

            modelBuilder.Entity("Core.Entities.LangTextArchive", b =>
                {
                    b.HasOne("Core.Entities.GameVersion", "GameVersion")
                        .WithMany()
                        .HasForeignKey("GameApiVersion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.LangTypeCatalog", "LangCatalog")
                        .WithMany()
                        .HasForeignKey("IdType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.User", "UserForReview")
                        .WithMany()
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.User", "UserForModify")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GameVersion");

                    b.Navigation("LangCatalog");

                    b.Navigation("UserForModify");

                    b.Navigation("UserForReview");
                });

            modelBuilder.Entity("Core.Entities.LangTextReview", b =>
                {
                    b.HasOne("Core.Entities.GameVersion", "GameVersion")
                        .WithMany()
                        .HasForeignKey("GameApiVersion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.LangTypeCatalog", "LangCatalog")
                        .WithMany()
                        .HasForeignKey("IdType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.User", "UserForReview")
                        .WithMany()
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.User", "UserForModify")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GameVersion");

                    b.Navigation("LangCatalog");

                    b.Navigation("UserForModify");

                    b.Navigation("UserForReview");
                });

            modelBuilder.Entity("Core.Entities.UserRegistrationCode", b =>
                {
                    b.HasOne("Core.Entities.User", "UserForRequest")
                        .WithMany()
                        .HasForeignKey("UserRequest")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.User", "UserForUsed")
                        .WithMany()
                        .HasForeignKey("UserUsed");

                    b.Navigation("UserForRequest");

                    b.Navigation("UserForUsed");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Core.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Core.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
