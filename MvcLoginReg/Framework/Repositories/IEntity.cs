using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLoginReg.Framework.Repositories
{
    public interface IEntity : IEntity<int> { }
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}