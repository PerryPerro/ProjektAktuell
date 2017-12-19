using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcLoginReg.Models;
using MvcLoginReg.Repositories;

namespace MvcLoginReg.Framework.Login
{
    public class CustomUserStore : UserStore<UserAccount>
    {
        public CustomUserStore(MyDbContext dataContext) : base(dataContext)
        {

        }
    }
}