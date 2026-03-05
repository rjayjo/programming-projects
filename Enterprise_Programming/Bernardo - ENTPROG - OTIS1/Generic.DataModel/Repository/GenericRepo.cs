using Bernardo___ENTPROG___OTIS1;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.DataModel.Repository
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly AppDbContext context;

        public GenericRepo(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<T> AddAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            context.Accessed2();
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        { 

            var entity = await context.Set<T>().FindAsync(id);
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();

        }

        public async Task<bool> Exists(int id)
        {
            T entity = await context.Set<T>().FindAsync(id);
            if (entity != null) return true; 
            else return false;
        }

      
        public async Task<List<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            T entity = await context.Set<T>().FindAsync(id);
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            context.Set<T>().Update(entity);
            context.Accessed2();
            await context.SaveChangesAsync();
        }

   

       
    }
}
