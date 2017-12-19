using MvcLoginReg.Models;
using MvcLoginReg.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLoginReg.Framework.Repositories
{
    public class UserRepository : Repository<User, string>
    {
        public UserRepository(MyDbContext context) : base(context)
        {

        }

        internal User GetByName(string username)
        {
            var user = Items.SingleOrDefault(x => x.Name.ToLower() == username.ToLower());
            return user;
        }
    }
}