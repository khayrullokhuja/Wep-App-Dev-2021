using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WAD.DAL._7607.DBO;

namespace WAD.DAL._7607.Repositories
{
    public class DepartmentRep : BaseRep, IRepositories<Department>
    {
        public DepartmentRep(SocialsCafeDbContext context)
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

        public Task<List<Department>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Department> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
