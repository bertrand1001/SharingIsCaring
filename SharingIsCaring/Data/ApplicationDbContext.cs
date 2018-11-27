using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SharingIsCaring.Models;

namespace SharingIsCaring.Data
{
    public class ApplicationDbContext : IdentityDbContext <AppUser, AppRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SharingIsCaring.Models.Product> Product { get; set; }
    }
}
