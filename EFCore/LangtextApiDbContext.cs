﻿using Core.Entities;
using EFCore.TestData;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore
{
    public class LangtextApiDbContext : IdentityDbContext<User, Role, Guid>
    {
        public LangtextApiDbContext(DbContextOptions<LangtextApiDbContext> options) : base(options)
        {

        }

        public DbSet<LangText> Langtexts { get; set; }
        public DbSet<LangTextReview> LangtextReview { get; set; }
        public DbSet<LangTextArchive> LangtextArchive { get; set; }
        public DbSet<LangTextRevised> LangtextRevised { get; set; }
        public DbSet<LangTextRevNumber> LangtextRevNumber { get; set; }
        public DbSet<UserRegistrationCode> UserRegistrationCode { get; set; }
        public DbSet<LangTypeCatalog> LangTypeCatalog { get; set; }
        public DbSet<LangTypeCatalogReview> LangTypeCatalogReview { get; set; }
        public DbSet<GameVersion> GameVersion { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.SeedData();
        //}
    }
}
