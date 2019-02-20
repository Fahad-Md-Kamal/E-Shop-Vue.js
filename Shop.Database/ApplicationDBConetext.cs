using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Database
{
    public class ApplicationDBConetext : IdentityDbContext
    {
        public ApplicationDBConetext(DbContextOptions options) 
            : base(options)  {  }

        public DbSet<Product> Product { get; set; }
    }
}
