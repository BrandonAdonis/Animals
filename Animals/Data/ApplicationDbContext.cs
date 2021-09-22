using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Animals.Models;

namespace Animals.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Animals.Models.Animal> Animal { get; set; }
        public DbSet<Animals.Models.Food> Food { get; set; }
        public DbSet<Animals.Models.StaffMember> StaffMember { get; set; }
    }
}
