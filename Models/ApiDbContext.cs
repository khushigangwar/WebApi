﻿using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public class ApiDbContext : DbContext
    {
            public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { 
        
        }
        public DbSet<Users> users {  get; set; }
    }
}
