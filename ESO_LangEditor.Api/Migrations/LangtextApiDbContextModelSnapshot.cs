﻿// <auto-generated />
using System;
using ESO_LangEditor.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ESO_LangEditor.API.Migrations
{
    [DbContext(typeof(LangtextApiDbContext))]
    partial class LangtextApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("ESO_LangEditor.Core.Entities.LangText", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("EnLastModifyTimestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("IdType")
                        .HasColumnType("integer");

                    b.Property<byte>("IsTranslated")
                        .HasColumnType("smallint");

                    b.Property<byte>("LangTextType")
                        .HasColumnType("smallint");

                    b.Property<Guid?>("LangtextInReivewId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ReviewTimestamp")
                        .HasColumnType("timestamp without time zone");

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

                    b.Property<string>("UpdateStats")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ZhLastModifyTimestamp")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("LangtextInReivewId");

                    b.HasIndex("ReviewerId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("Langtexts");
                });

            modelBuilder.Entity("ESO_LangEditor.Core.Entities.LangTextArchive", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ArchiveTimestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("EnLastModifyTimestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("IdType")
                        .HasColumnType("integer");

                    b.Property<byte>("IsTranslated")
                        .HasColumnType("smallint");

                    b.Property<byte>("LangTextType")
                        .HasColumnType("smallint");

                    b.Property<int>("ReasonFor")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ReviewTimestamp")
                        .HasColumnType("timestamp without time zone");

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

                    b.Property<string>("UpdateStats")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ZhLastModifyTimestamp")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ReviewerId");

                    b.HasIndex("UserId");

                    b.ToTable("LangtextArchive");
                });

            modelBuilder.Entity("ESO_LangEditor.Core.Entities.LangTextRevNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Rev")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("LangtextRevNumber");
                });

            modelBuilder.Entity("ESO_LangEditor.Core.Entities.LangTextReview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("EnLastModifyTimestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("IdType")
                        .HasColumnType("integer");

                    b.Property<byte>("IsTranslated")
                        .HasColumnType("smallint");

                    b.Property<byte>("LangTextType")
                        .HasColumnType("smallint");

                    b.Property<int>("ReasonFor")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ReviewTimestamp")
                        .HasColumnType("timestamp without time zone");

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

                    b.Property<string>("UpdateStats")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("ZhLastModifyTimestamp")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ReviewerId");

                    b.HasIndex("UserId");

                    b.ToTable("LangtextReview");
                });

            modelBuilder.Entity("ESO_LangEditor.Core.Entities.LangTextRevised", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("LangTextRevNumber")
                        .HasColumnType("integer");

                    b.Property<Guid>("LangtextID")
                        .HasColumnType("uuid");

                    b.Property<int>("ReasonFor")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("LangtextRevised");
                });

            modelBuilder.Entity("ESO_LangEditor.Core.Entities.Role", b =>
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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("ESO_LangEditor.Core.Entities.User", b =>
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
                        .HasColumnType("timestamp without time zone");

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

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ESO_LangEditor.Core.Entities.UserRegistrationCode", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<DateTime>("RequestTimestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("UsedTimestamp")
                        .HasColumnType("timestamp without time zone");

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
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ESO_LangEditor.Core.Entities.LangText", b =>
                {
                    b.HasOne("ESO_LangEditor.Core.Entities.LangTextReview", "LangtextInReview")
                        .WithMany()
                        .HasForeignKey("LangtextInReivewId");

                    b.HasOne("ESO_LangEditor.Core.Entities.User", "UserForReview")
                        .WithMany()
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ESO_LangEditor.Core.Entities.Role", "RoleToEdit")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ESO_LangEditor.Core.Entities.User", "UserForModify")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LangtextInReview");

                    b.Navigation("RoleToEdit");

                    b.Navigation("UserForModify");

                    b.Navigation("UserForReview");
                });

            modelBuilder.Entity("ESO_LangEditor.Core.Entities.LangTextArchive", b =>
                {
                    b.HasOne("ESO_LangEditor.Core.Entities.User", "UserForReview")
                        .WithMany()
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ESO_LangEditor.Core.Entities.User", "UserForModify")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserForModify");

                    b.Navigation("UserForReview");
                });

            modelBuilder.Entity("ESO_LangEditor.Core.Entities.LangTextReview", b =>
                {
                    b.HasOne("ESO_LangEditor.Core.Entities.User", "UserForReview")
                        .WithMany()
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ESO_LangEditor.Core.Entities.User", "UserForModify")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserForModify");

                    b.Navigation("UserForReview");
                });

            modelBuilder.Entity("ESO_LangEditor.Core.Entities.UserRegistrationCode", b =>
                {
                    b.HasOne("ESO_LangEditor.Core.Entities.User", "UserForRequest")
                        .WithMany()
                        .HasForeignKey("UserRequest")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ESO_LangEditor.Core.Entities.User", "UserForUsed")
                        .WithMany()
                        .HasForeignKey("UserUsed");

                    b.Navigation("UserForRequest");

                    b.Navigation("UserForUsed");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("ESO_LangEditor.Core.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("ESO_LangEditor.Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("ESO_LangEditor.Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("ESO_LangEditor.Core.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ESO_LangEditor.Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("ESO_LangEditor.Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
