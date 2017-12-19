using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcLoginReg.Models;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MvcLoginReg.Repositories
{
    public class MyDbContext : IdentityDbContext<UserAccount>
    {
        public DbSet<UserAccount> userAccount { get; set; }
    }
}