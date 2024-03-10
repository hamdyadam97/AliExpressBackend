using AliExpress.Application.Contract;
using AliExpress.Context;
using AliExpress.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliExpress.Infrastructure
{
    public class Repository<TEntity, Tid> : IRepository<TEntity, Tid> where TEntity : BaseEntity
    {
        private readonly AliExpressContext _aliExpressContext;
        private readonly DbSet<TEntity> _Dbset;


        public Repository(AliExpressContext aliExpressContext ) 
        {
            _aliExpressContext = aliExpressContext;
            _Dbset = _aliExpressContext.Set<TEntity>();


        }
        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            return (await _Dbset.AddAsync(entity)).Entity;
        }

        public Task<TEntity> DeleteAsync(TEntity entity)
        {
            return Task.FromResult((_Dbset.Remove(entity)).Entity);
        }

        public Task<IQueryable<TEntity>> GetAllAsync()
        {
            return Task.FromResult(_Dbset.Select(P => P));
        }


        public async Task<TEntity> GetByIdAsync(Tid id)
        {
            return await _Dbset.FindAsync(id);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _aliExpressContext.SaveChangesAsync();
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            return Task.FromResult(_Dbset.Update(entity).Entity);
        }
    }
}
