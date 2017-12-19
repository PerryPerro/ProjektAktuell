using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcLoginReg.Framework;
using Microsoft.AspNet.Identity.EntityFramework;
using MvcLoginReg.Repositories;

namespace MvcLoginReg.Models
{
    public class AppUserManager : UserManager<UserAccount>
    {
        public AppUserManager(IUserStore<UserAccount> store)
            : base(store)
        {
        }

        // this method is called by Owin therefore best place to configure your User Manager
        public static AppUserManager Create(
            IdentityFactoryOptions<AppUserManager> options, IOwinContext context)
        {
            var manager = new AppUserManager(
                new UserStore<UserAccount>(context.Get<MyDbContext>()));

            // optionally configure your manager
            // ...

            return manager;
        }
    }
}