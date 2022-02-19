﻿using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
    }

}
