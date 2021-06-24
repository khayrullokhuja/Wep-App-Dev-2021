using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WAD.DAL._7607.DBO;

namespace WAD.DAL._7607.Repositories
{
    public class CafeRep : BaseRep, IRepositories<Cafe>
    {
        public CafeRep(SocialsCafeDbContext context)
            : base(context)
        {
        }
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Cafe>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Cafe> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
