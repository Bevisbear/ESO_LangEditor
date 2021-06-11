﻿using ESO_LangEditor.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace ESO_LangEditor.GUI.Services
{
    public class LangDbContext : DbContext
    {
        public DbSet<LangTextDto> LangData { get; set; }
        //public DbSet<LuaUIData> LuaLang { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseSqlite(@"Data Source=Data/LangData_v3.db");

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<LangData>();
        //    modelBuilder.Entity<List<LangData>>();
        //}
    }
}