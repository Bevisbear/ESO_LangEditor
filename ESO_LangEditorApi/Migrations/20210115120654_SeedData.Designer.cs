﻿// <auto-generated />
using System;
using ESO_LangEditor.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ESO_LangEditor.API.Migrations
{
    [DbContext(typeof(LangtextApiDbContext))]
    [Migration("20210115120654_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

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

                    b.Property<DateTime>("ReviewTimestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("ReviewerId")
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

                    b.ToTable("Langtexts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7639d924-b155-4f58-b45e-ff87bf0dba9b"),
                            EnLastModifyTimestamp = new DateTime(2020, 11, 2, 21, 48, 38, 593, DateTimeKind.Unspecified).AddTicks(6908),
                            IdType = 115740052,
                            IsTranslated = (byte)2,
                            LangTextType = (byte)4,
                            ReviewTimestamp = new DateTime(2021, 1, 15, 20, 6, 53, 941, DateTimeKind.Local).AddTicks(4879),
                            ReviewerId = new Guid("8475b578-80f4-4ed0-ae41-c32a45d6d9e6"),
                            TextEn = "Whatever you say! I'll see what I can find out.",
                            TextId = "115740052-0-11491",
                            TextZh = "按你说的办！我去看看我能发现什么。",
                            UpdateStats = "Update24",
                            UserId = new Guid("8475b578-80f4-4ed0-ae41-c32a45d6d9e6"),
                            ZhLastModifyTimestamp = new DateTime(2020, 11, 17, 8, 55, 12, 335, DateTimeKind.Unspecified).AddTicks(8170)
                        },
                        new
                        {
                            Id = new Guid("3d284691-b117-44ea-bdfa-52e19b7e8612"),
                            EnLastModifyTimestamp = new DateTime(2020, 11, 2, 21, 48, 38, 684, DateTimeKind.Unspecified).AddTicks(6146),
                            IdType = 200879108,
                            IsTranslated = (byte)2,
                            LangTextType = (byte)4,
                            ReviewTimestamp = new DateTime(2021, 1, 15, 20, 6, 53, 941, DateTimeKind.Local).AddTicks(5727),
                            ReviewerId = new Guid("8475b578-80f4-4ed0-ae41-c32a45d6d9e6"),
                            TextEn = "No. Doesn't have a clue. That's what makes it so exciting!\\n\\nThis is an honest-to-goodness secret mission! I always wanted to go on a secret mission! Besides, once you talk to Solgra, you'll understand. She explains things much better than I do.",
                            TextId = "200879108-0-40943",
                            TextZh = "不，不知道怎么回事。这才是让人激动的地方！\\n\\n这可是件货真价实的秘密任务！我一直希望要参与这样的任务来着！还有，你和索尔葛拉交谈的时候就会懂了。她解释起东西来比我好多了。",
                            UpdateStats = "Update24",
                            UserId = new Guid("18f825ff-46f5-4a1a-9b10-56be5fb2398d"),
                            ZhLastModifyTimestamp = new DateTime(2020, 11, 17, 8, 33, 10, 457, DateTimeKind.Unspecified).AddTicks(8998)
                        },
                        new
                        {
                            Id = new Guid("7b0a678d-04d1-4442-86ab-e7c3ffb207e0"),
                            EnLastModifyTimestamp = new DateTime(2020, 11, 2, 21, 48, 38, 684, DateTimeKind.Unspecified).AddTicks(6233),
                            IdType = 200879108,
                            IsTranslated = (byte)2,
                            LangTextType = (byte)4,
                            ReviewTimestamp = new DateTime(2021, 1, 15, 20, 6, 53, 941, DateTimeKind.Local).AddTicks(5763),
                            ReviewerId = new Guid("8475b578-80f4-4ed0-ae41-c32a45d6d9e6"),
                            TextEn = "A well? Yeah, I saw the old well. We'll need a rope or something to climb down, though.\\n\\nCheck near the forge. I noticed tools and ropes hanging around. One of those ropes should serve our needs.",
                            TextId = "200879108-0-40960",
                            TextZh = "一口井？对，我看到那口老井了。我们需要绳子之类的才能爬下去。\\n\\n看看熔炉附近，我发现了一些工具和绳子挂在周围。应该会有绳子供我们所需。",
                            UpdateStats = "Update24",
                            UserId = new Guid("18f825ff-46f5-4a1a-9b10-56be5fb2398d"),
                            ZhLastModifyTimestamp = new DateTime(2020, 11, 17, 9, 15, 31, 590, DateTimeKind.Unspecified).AddTicks(1130)
                        },
                        new
                        {
                            Id = new Guid("4ca5183a-f0dd-4f6f-b664-58a647df535c"),
                            EnLastModifyTimestamp = new DateTime(2020, 11, 2, 21, 48, 38, 684, DateTimeKind.Unspecified).AddTicks(6887),
                            IdType = 200879108,
                            IsTranslated = (byte)2,
                            LangTextType = (byte)4,
                            ReviewTimestamp = new DateTime(2021, 1, 15, 20, 6, 53, 941, DateTimeKind.Local).AddTicks(5782),
                            ReviewerId = new Guid("8475b578-80f4-4ed0-ae41-c32a45d6d9e6"),
                            TextEn = "Have you seen my bow skills? I'm sure Solgra noticed and said to herself, \"That's a fine young lass! She can put a shaft through an apple balanced on the back of a moving wamasu. I shall recruit her!\"\\n\\nEither that or she was desperate for some help.",
                            TextId = "200879108-0-40993",
                            TextZh = "你没看到我的弓术吗？我确定索尔葛拉注意到了，还自言自语着“那个姑娘可真厉害！她可以射穿放在一只移动中的雷霆蜥蜴背上的苹果，我应该招募她！“\\n\\n或者也可能是她实在是无处求救了。",
                            UpdateStats = "Update24",
                            UserId = new Guid("18f825ff-46f5-4a1a-9b10-56be5fb2398d"),
                            ZhLastModifyTimestamp = new DateTime(2020, 11, 17, 8, 37, 34, 984, DateTimeKind.Unspecified).AddTicks(7945)
                        },
                        new
                        {
                            Id = new Guid("6cfaec5e-be72-4537-890b-696e5cd33b09"),
                            EnLastModifyTimestamp = new DateTime(2020, 11, 2, 21, 48, 38, 632, DateTimeKind.Unspecified).AddTicks(4910),
                            IdType = 132143172,
                            IsTranslated = (byte)2,
                            LangTextType = (byte)4,
                            ReviewTimestamp = new DateTime(2021, 1, 15, 20, 6, 53, 941, DateTimeKind.Local).AddTicks(5798),
                            ReviewerId = new Guid("8475b578-80f4-4ed0-ae41-c32a45d6d9e6"),
                            TextEn = "Devastate an enemy with an enhanced charge from your staff, dealing <<1>> and an additional <<2>> over <<3>>.",
                            TextId = "132143172-0-29078",
                            TextZh = "以法杖的强化力量破坏敌人， 造成 <<1>> 并在<<3>>内造成额外<<2>> 。",
                            UpdateStats = "Update24",
                            UserId = new Guid("18f825ff-46f5-4a1a-9b10-56be5fb2398d"),
                            ZhLastModifyTimestamp = new DateTime(2020, 11, 10, 1, 50, 9, 975, DateTimeKind.Unspecified).AddTicks(2877)
                        },
                        new
                        {
                            Id = new Guid("0762d175-5a6f-43b4-9dea-b9c28d5d4b0e"),
                            EnLastModifyTimestamp = new DateTime(2020, 11, 2, 21, 48, 38, 714, DateTimeKind.Unspecified).AddTicks(4141),
                            IdType = 198758357,
                            IsTranslated = (byte)2,
                            LangTextType = (byte)4,
                            ReviewTimestamp = new DateTime(2021, 1, 15, 20, 6, 53, 941, DateTimeKind.Local).AddTicks(5815),
                            ReviewerId = new Guid("8475b578-80f4-4ed0-ae41-c32a45d6d9e6"),
                            TextEn = "Brutal Carnage",
                            TextId = "198758357-0-137184",
                            TextZh = "残暴杀戮",
                            UpdateStats = "Update26",
                            UserId = new Guid("18f825ff-46f5-4a1a-9b10-56be5fb2398d"),
                            ZhLastModifyTimestamp = new DateTime(2020, 11, 7, 6, 35, 2, 791, DateTimeKind.Unspecified).AddTicks(5322)
                        },
                        new
                        {
                            Id = new Guid("cd017b93-0d0d-4c35-8bfc-9e82665ec817"),
                            EnLastModifyTimestamp = new DateTime(2020, 11, 2, 21, 48, 38, 132, DateTimeKind.Unspecified).AddTicks(9690),
                            IdType = 8290981,
                            IsTranslated = (byte)2,
                            LangTextType = (byte)4,
                            ReviewTimestamp = new DateTime(2021, 1, 15, 20, 6, 53, 941, DateTimeKind.Local).AddTicks(5833),
                            ReviewerId = new Guid("8475b578-80f4-4ed0-ae41-c32a45d6d9e6"),
                            TextEn = "Za'ji^M",
                            TextId = "8290981-0-91160",
                            TextZh = "扎'吉^M",
                            UpdateStats = "Update24",
                            UserId = new Guid("18f825ff-46f5-4a1a-9b10-56be5fb2398d"),
                            ZhLastModifyTimestamp = new DateTime(2020, 11, 16, 20, 6, 42, 494, DateTimeKind.Unspecified).AddTicks(8770)
                        },
                        new
                        {
                            Id = new Guid("de09f1b2-7a2c-4bbc-8f16-b5fde4317d84"),
                            EnLastModifyTimestamp = new DateTime(2020, 11, 2, 21, 48, 37, 913, DateTimeKind.Unspecified).AddTicks(8204),
                            IdType = 242841733,
                            IsTranslated = (byte)2,
                            LangTextType = (byte)4,
                            ReviewTimestamp = new DateTime(2021, 1, 15, 20, 6, 53, 941, DateTimeKind.Local).AddTicks(5850),
                            ReviewerId = new Guid("8475b578-80f4-4ed0-ae41-c32a45d6d9e6"),
                            TextEn = "Restoration Staff of Kyne's Wind",
                            TextId = "242841733-0-162450",
                            TextZh = "凯娜之风治疗法杖",
                            UpdateStats = "Update26",
                            UserId = new Guid("18f825ff-46f5-4a1a-9b10-56be5fb2398d"),
                            ZhLastModifyTimestamp = new DateTime(2020, 11, 19, 16, 36, 22, 946, DateTimeKind.Unspecified).AddTicks(4880)
                        },
                        new
                        {
                            Id = new Guid("d7480da5-602f-4b5e-8a03-5a95fbd34c1d"),
                            EnLastModifyTimestamp = new DateTime(2020, 11, 2, 22, 14, 22, 325, DateTimeKind.Unspecified).AddTicks(5283),
                            IdType = 100,
                            IsTranslated = (byte)2,
                            LangTextType = (byte)3,
                            ReviewTimestamp = new DateTime(2021, 1, 15, 20, 6, 53, 941, DateTimeKind.Local).AddTicks(5866),
                            ReviewerId = new Guid("8475b578-80f4-4ed0-ae41-c32a45d6d9e6"),
                            TextEn = "Two-Handed Melee",
                            TextId = "SI_EQUIPMENTFILTERTYPE8",
                            TextZh = "双手武器近战",
                            UpdateStats = "Update28",
                            UserId = new Guid("18f825ff-46f5-4a1a-9b10-56be5fb2398d"),
                            ZhLastModifyTimestamp = new DateTime(2020, 11, 19, 16, 28, 39, 667, DateTimeKind.Unspecified).AddTicks(4052)
                        });
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

                    b.Property<DateTime>("ReviewTimestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("ReviewerId")
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

                    b.ToTable("LangtextArchive");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d05c0e82-025e-4e31-97ae-b8858ab0a784"),
                            ArchiveTimestamp = new DateTime(2021, 1, 15, 20, 6, 53, 943, DateTimeKind.Local).AddTicks(5482),
                            EnLastModifyTimestamp = new DateTime(2020, 11, 2, 21, 48, 38, 613, DateTimeKind.Unspecified).AddTicks(4703),
                            IdType = 103224356,
                            IsTranslated = (byte)2,
                            LangTextType = (byte)4,
                            ReviewTimestamp = new DateTime(2021, 1, 15, 20, 6, 53, 943, DateTimeKind.Local).AddTicks(4826),
                            ReviewerId = new Guid("8475b578-80f4-4ed0-ae41-c32a45d6d9e6"),
                            TextEn = "We need to meet with General Renmus as soon as possible. To do this, I must bribe his clerk, obtain forged credentials, and delay the merchant who is currently scheduled to meet with him.",
                            TextId = "103224356-0-51125",
                            TextZh = "我们要尽快与瑞摩斯将军会面。为此，我要贿赂他的雇员，获取伪造的凭证，然后去拖延本应和他会面的商人。",
                            UpdateStats = "Update24",
                            UserId = new Guid("18f825ff-46f5-4a1a-9b10-56be5fb2398d"),
                            ZhLastModifyTimestamp = new DateTime(2020, 11, 16, 20, 53, 23, 487, DateTimeKind.Unspecified).AddTicks(1752)
                        },
                        new
                        {
                            Id = new Guid("08d42f95-66ff-4bcb-adc7-b395f436086c"),
                            ArchiveTimestamp = new DateTime(2021, 1, 15, 20, 6, 53, 943, DateTimeKind.Local).AddTicks(6215),
                            EnLastModifyTimestamp = new DateTime(2020, 11, 2, 21, 48, 38, 626, DateTimeKind.Unspecified).AddTicks(4609),
                            IdType = 139139780,
                            IsTranslated = (byte)2,
                            LangTextType = (byte)4,
                            ReviewTimestamp = new DateTime(2021, 1, 15, 20, 6, 53, 943, DateTimeKind.Local).AddTicks(6201),
                            ReviewerId = new Guid("8475b578-80f4-4ed0-ae41-c32a45d6d9e6"),
                            TextEn = "A manifest of items shipped by Arniel Branck.",
                            TextId = "139139780-0-7300",
                            TextZh = "阿尼尔·布兰克运输货品的清单。",
                            UpdateStats = "Update25",
                            UserId = new Guid("18f825ff-46f5-4a1a-9b10-56be5fb2398d"),
                            ZhLastModifyTimestamp = new DateTime(2020, 11, 16, 21, 51, 37, 734, DateTimeKind.Unspecified).AddTicks(8102)
                        },
                        new
                        {
                            Id = new Guid("ba652528-900f-437b-8832-eb6d387ad010"),
                            ArchiveTimestamp = new DateTime(2021, 1, 15, 20, 6, 53, 943, DateTimeKind.Local).AddTicks(6244),
                            EnLastModifyTimestamp = new DateTime(2020, 11, 2, 21, 48, 38, 673, DateTimeKind.Unspecified).AddTicks(397),
                            IdType = 115740052,
                            IsTranslated = (byte)2,
                            LangTextType = (byte)4,
                            ReviewTimestamp = new DateTime(2021, 1, 15, 20, 6, 53, 943, DateTimeKind.Local).AddTicks(6243),
                            ReviewerId = new Guid("8475b578-80f4-4ed0-ae41-c32a45d6d9e6"),
                            TextEn = "I don't see Nartise. Let's move on.",
                            TextId = "115740052-0-35623",
                            TextZh = "没看见纳蒂斯，我们继续。",
                            UpdateStats = "Update24",
                            UserId = new Guid("18f825ff-46f5-4a1a-9b10-56be5fb2398d"),
                            ZhLastModifyTimestamp = new DateTime(2020, 11, 16, 22, 20, 37, 622, DateTimeKind.Unspecified).AddTicks(9099)
                        });
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

                    b.Property<DateTime>("ReviewTimestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("ReviewerId")
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

                    b.ToTable("LangtextReview");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9a04bae0-b14a-4015-9b51-f0f04137000a"),
                            EnLastModifyTimestamp = new DateTime(2020, 11, 2, 22, 14, 22, 325, DateTimeKind.Unspecified).AddTicks(5292),
                            IdType = 100,
                            IsTranslated = (byte)2,
                            LangTextType = (byte)3,
                            ReviewTimestamp = new DateTime(2021, 1, 15, 20, 6, 53, 943, DateTimeKind.Local).AddTicks(1637),
                            ReviewerId = new Guid("8475b578-80f4-4ed0-ae41-c32a45d6d9e6"),
                            TextEn = "Destruction Staff",
                            TextId = "SI_EQUIPMENTFILTERTYPE9",
                            TextZh = "毁灭法杖",
                            UpdateStats = "Update28",
                            UserId = new Guid("18f825ff-46f5-4a1a-9b10-56be5fb2398d"),
                            ZhLastModifyTimestamp = new DateTime(2020, 11, 19, 16, 33, 30, 2, DateTimeKind.Unspecified).AddTicks(4484)
                        },
                        new
                        {
                            Id = new Guid("5a1a90b8-183f-4d78-a76b-a00ed7889b84"),
                            EnLastModifyTimestamp = new DateTime(2020, 11, 2, 22, 14, 22, 325, DateTimeKind.Unspecified).AddTicks(6276),
                            IdType = 100,
                            IsTranslated = (byte)2,
                            LangTextType = (byte)2,
                            ReviewTimestamp = new DateTime(2021, 1, 15, 20, 6, 53, 943, DateTimeKind.Local).AddTicks(2423),
                            ReviewerId = new Guid("8475b578-80f4-4ed0-ae41-c32a45d6d9e6"),
                            TextEn = "All Materials",
                            TextId = "SI_GAMEPAD_ALCHEMY_ALL_MATERIALS",
                            TextZh = "所有材料",
                            UpdateStats = "Update28",
                            UserId = new Guid("18f825ff-46f5-4a1a-9b10-56be5fb2398d"),
                            ZhLastModifyTimestamp = new DateTime(2020, 11, 19, 16, 10, 59, 646, DateTimeKind.Unspecified).AddTicks(7889)
                        },
                        new
                        {
                            Id = new Guid("c9b3970d-e7d5-4290-939a-563466f13203"),
                            EnLastModifyTimestamp = new DateTime(2020, 11, 2, 21, 48, 38, 582, DateTimeKind.Unspecified).AddTicks(6411),
                            IdType = 10860933,
                            IsTranslated = (byte)2,
                            LangTextType = (byte)4,
                            ReviewTimestamp = new DateTime(2021, 1, 15, 20, 6, 53, 943, DateTimeKind.Local).AddTicks(2457),
                            ReviewerId = new Guid("8475b578-80f4-4ed0-ae41-c32a45d6d9e6"),
                            TextEn = "Dungeon: Selene's Web",
                            TextId = "10860933-0-964",
                            TextZh = "组队副本：瑟琳之网",
                            UpdateStats = "Update24",
                            UserId = new Guid("18f825ff-46f5-4a1a-9b10-56be5fb2398d"),
                            ZhLastModifyTimestamp = new DateTime(2020, 11, 21, 18, 46, 32, 775, DateTimeKind.Unspecified).AddTicks(4132)
                        });
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
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

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
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
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
