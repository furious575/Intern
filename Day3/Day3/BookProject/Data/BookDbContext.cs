﻿using BookProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;

namespace BookProject.Data
{
    public class BookDbContext : DbContext
    {

        public BookDbContext (DbContextOptions<BookDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=.;Database=BookDb;Integreated Security= True ");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
