using _012.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _012.Data
{
    public class ApplicationDbContext : IdentityDbContext//if it's just DbContext, 
        //then all Identity tables disappear after migration
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Accounts> AccountsT { get; set; }//the white  name is the
        //name of the future table
        public DbSet<Card> CardT { get; set; }
    }
}
