using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WAD.DAL._7607.Repositories
{
    public interface IRepositories<T> where T : class
    {
        Task<List<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        bool Exists(int id);

        Task DeleteAsync(int id);
    }
}
