using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksesRepo.DataModel.Repository
{
    public interface IAksesRepo<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task<List<T>> GetAllAsync();
        Task DeleteAsync(int id);
        Task<T> GetAsync(int id);
        Task UpdateAsync(T entity);
        Task<bool> Exists(int id);
    }
}
