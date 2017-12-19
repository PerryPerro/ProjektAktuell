using Microsoft.AspNet.Identity.EntityFramework;
using MvcLoginReg.Framework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLoginReg.Models
{
    public class User : IdentityUser, IEntity<string>
    {
        public string Name { get; set; }
    }
}