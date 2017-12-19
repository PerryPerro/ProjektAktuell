using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using MvcLoginReg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace MvcLoginReg.Framework.Login
{
    public class ApplicationSignInManager : SignInManager<Users, string>
    {
        public ApplicationSignInManager(UserAccountManager userManager, IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager)
        {
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(User user)
        {
            return UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
        }
    }
}