using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcLoginReg.Models;
using System.Data.Entity;

namespace MvcLoginReg.Repositories
{
    public class MyDbContext : DbContext
    {
        public DbSet<UserAccount> userAccount { get; set; }
    }
}