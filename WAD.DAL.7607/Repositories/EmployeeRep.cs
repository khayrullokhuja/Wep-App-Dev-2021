using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WAD.DAL._7607.DBO;

namespace WAD.DAL._7607.Repositories
{
    public class EmployeeRep : BaseRep, IRepositories<Employee>
    {
        public EmployeeRep(SocialsCafeDbContext context)
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

        public Task<List<Employee>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
