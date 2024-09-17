using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsSocialMediaApp.Models
{

    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}


