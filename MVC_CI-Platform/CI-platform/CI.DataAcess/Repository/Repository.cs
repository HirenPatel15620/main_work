﻿using CI.Repository.Repository.IRepository;
using CI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CI.Repository.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly CiPlatformContext _db;
        internal DbSet<T> dbset;
        public Repository(CiPlatformContext db)
        {
            _db = db;
            this.dbset=_db.Set<T>();
        }
        public void Add(T entity)
        {
           dbset.Add(entity);
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return dbset;
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbset;
            query=query.Where(filter);
            return query.FirstOrDefault();

        }
    }
}
