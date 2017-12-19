using MvcLoginReg.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcLoginReg.Framework.Repositories
{
    public abstract class Repository<T, TKey> where T : class, IEntity<TKey>
    {
        private readonly MyDbContext context;

        public Repository(MyDbContext context)
        {
            this.context = context;
        }

        public DbSet<T> Items => context.Set<T>();

        public T Get(TKey id)
        {
            return Items.Find(id);
        }

        public List<T> GetAll()
        {
            return Items.ToList();
        }

        public void Add(T item)
        {
            Items.Add(item);
        }

        public void Remove(TKey id)
        {
            var item = Get(id);
            Items.Remove(item);
        }

        public void Edit(T item)
        {
            context.Entry(item).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}